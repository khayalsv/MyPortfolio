using Microsoft.AspNetCore.Mvc;

namespace KSPort.ViewComponents.Default
{
    public class _Blog : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
