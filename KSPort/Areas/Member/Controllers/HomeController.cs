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
        public async Task<IActionResult> Create(Home p)
        {
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/myimg/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                p.ImageUrl = imagename;
            }
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
        public async Task<IActionResult> Edit(Home p)
        {
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/myimg/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                p.ImageUrl = imagename;
            }
            homeManager.TUpdate(p);
            return Redirect("/Member/Home/Index");
        }

    }
}
