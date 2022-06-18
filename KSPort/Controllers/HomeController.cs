using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.Controllers
{
    public class HomeController : Controller
    {
        HomeManager homeManager = new HomeManager(new EfHomeDal());
        public IActionResult Index()
        {
            var values = homeManager.TGetList();
            return View(values);
        }
    }
}
