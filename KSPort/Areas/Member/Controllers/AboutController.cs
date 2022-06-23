using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.Areas.Member.Controllers
{
    [Area("Member")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(About p)
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
            aboutManager.Tadd(p);

            return Redirect("/Member/About/Index");
        }


        public IActionResult Delete(int id)
        {
            var value = aboutManager.TGetByID(id);
            aboutManager.TDelete(value);
            return Redirect("/Member/About/Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = aboutManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(About p)
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
            aboutManager.TUpdate(p);
            return Redirect("/Member/About/Index");
        }

    }
}
