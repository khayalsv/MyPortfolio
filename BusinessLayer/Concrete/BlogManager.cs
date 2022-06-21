using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Tadd(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public Blog TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetList();
        }

        public void TUpdate(Blog t)
        {
            throw new System.NotImplementedException();
        }
    }
}
