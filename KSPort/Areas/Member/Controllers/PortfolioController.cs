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
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Portfolio p)
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
            portfolioManager.Tadd(p);

            return Redirect("/Member/Portfolio/Index");
        }


        public IActionResult Delete(int id)
        {
            var value = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(value);
            return Redirect("/Member/Portfolio/Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = portfolioManager.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Portfolio p)
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
            portfolioManager.TUpdate(p);
            return Redirect("/Member/Portfolio/Index");
        }

    }
}
