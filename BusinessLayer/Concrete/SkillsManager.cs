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
            throw new System.NotImplementedException();
        }

        public void TDelete(Skills t)
        {
            throw new System.NotImplementedException();
        }

        public Skills TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Skills> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skills t)
        {
            throw new System.NotImplementedException();
        }
    }
}
