using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.ViewComponents.Default
{
    public class _Home :ViewComponent
    {
        HomeManager homeManager = new HomeManager(new EfHomeDal());
        public IViewComponentResult Invoke()
        {
            var values = homeManager.TGetList();
            return View(values);
        }
    }
}
