using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfHomeDal : GenericRepository<Home>, IHomeDal
    {
    }
}
