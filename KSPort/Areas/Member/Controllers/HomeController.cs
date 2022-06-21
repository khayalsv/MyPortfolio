using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.Areas.Member.Controllers
{
    [Area("Member")]
    public class HomeController : Controller
    {
        HomeManager homeManager = new HomeManager(new EfHomeDal());
        public IActionResult Index()
        {
            var values = homeManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Home p)
        {       
            homeManager.Tadd(p);
            return Redirect("/Member/Home/Index");
        }


        public IActionResult Delete(int id)
        {
            var value = homeManager.TGetByID(id);
            homeManager.TDelete(value);
            return Redirect("/Member/Home/Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value= homeManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Home p)
        {
            homeManager.TUpdate(p);
            return Redirect("/Member/Home/Index");
        }

    }
}
