using Microsoft.AspNetCore.Mvc;

namespace KSPort.ViewComponents.Default
{
    public class _Portfolio : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
