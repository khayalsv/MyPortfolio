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
            throw new System.NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new System.NotImplementedException();
        }

        public Contact TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _contactDAl.GetList();
        }

        public void TUpdate(Contact t)
        {
            throw new System.NotImplementedException();
        }
    }
}
