using Microsoft.AspNetCore.Mvc;

namespace KSPort.ViewComponents.Default
{
    public class _About : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
