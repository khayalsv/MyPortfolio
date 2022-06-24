using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDAl;

        public ContactManager(IContactDal contactDAl)
        {
            _contactDAl = contactDAl;
        }

        public void Tadd(Contact t)
        {
            _contactDAl.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDAl.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactDAl.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _contactDAl.GetList();
        }

        public void TUpdate(Contact t)
        {
            _contactDAl.Update(t);
        }
    }
}
