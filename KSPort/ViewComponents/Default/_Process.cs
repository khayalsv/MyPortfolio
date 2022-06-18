using Microsoft.AspNetCore.Mvc;

namespace KSPort.ViewComponents.Default
{
    public class _Process : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
