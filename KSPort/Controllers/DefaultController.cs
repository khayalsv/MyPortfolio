using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.Controllers
{
    public class DefaultController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Contact p)
        {

            contactManager.Tadd(p);

            return Redirect("/Default/Index");
        }

    }
}
