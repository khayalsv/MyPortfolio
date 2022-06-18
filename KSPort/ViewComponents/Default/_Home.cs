using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.ViewComponents.Default
{
    public class _Home :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
