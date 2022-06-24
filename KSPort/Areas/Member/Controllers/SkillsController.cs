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
    public class SkillsController : Controller
    {
        SkillsManager skillsManager = new SkillsManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillsManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Skills p)
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
            skillsManager.Tadd(p);

            return Redirect("/Member/Skills/Index");
        }


        public IActionResult Delete(int id)
        {
            var value = skillsManager.TGetByID(id);
            skillsManager.TDelete(value);
            return Redirect("/Member/Skills/Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = skillsManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Skills p)
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
            skillsManager.TUpdate(p);
            return Redirect("/Member/Skills/Index");
        }

    }
}
