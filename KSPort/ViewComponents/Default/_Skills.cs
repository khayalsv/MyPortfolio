using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KSPort.ViewComponents.Default
{
    public class _Skills : ViewComponent
    {
        SkillsManager skillsManager = new SkillsManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillsManager.TGetList();
            return View(values);
        }
    }
}
