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
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var values = blogManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog p)
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
            blogManager.Tadd(p);

            return Redirect("/Member/Blog/Index");
        }


        public IActionResult Delete(int id)
        {
            var value = blogManager.TGetByID(id);
            blogManager.TDelete(value);
            return Redirect("/Member/Blog/Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = blogManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Blog p)
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
            blogManager.TUpdate(p);
            return Redirect("/Member/Blog/Index");
        }

    }
}
