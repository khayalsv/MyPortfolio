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
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public Blog TGetByID(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> TGetList()
        {
            return _blogDal.GetList();
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
