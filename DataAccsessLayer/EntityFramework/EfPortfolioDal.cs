using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccsessLayer.EntityFramework
{
    public class EfPortfolioDal : GenericRepository<Portfolio>, IPortfolioDal
    {
    }

}
