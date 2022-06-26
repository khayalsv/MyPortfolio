using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.Areas.Member.Controllers
{
    [Authorize]
    [Authorize(Roles = "Admin")]
    [Area("Member")]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            var values = contactManager.TGetList();
            return View(values);
        }


        public IActionResult Delete(int id)
        {
            var value = contactManager.TGetByID(id);
            contactManager.TDelete(value);
            return Redirect("/Member/Contact/Index");
        }

    }
}

