using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccsessLayer.EntityFramework
{
    public class EfSkillDal : GenericRepository<Skills>, ISkillDal
    {
    }

}
