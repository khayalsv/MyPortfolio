using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class SkillsManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillsManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Tadd(Skills t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skills t)
        {
            _skillDal.Delete(t);
        }

        public Skills TGetByID(int id)
        {
            return _skillDal.GetById(id);
        }

        public List<Skills> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skills t)
        {
            _skillDal.Update(t);
        }
    }
}
