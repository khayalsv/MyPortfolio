using Microsoft.AspNetCore.Mvc;

namespace KSPort.ViewComponents.Default
{
    public class _Skills : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
