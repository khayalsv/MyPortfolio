﻿using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomeManager : IHomeService
    {
        IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public void Tadd(Home t)
        {
            _homeDal.Insert(t);
        }

        public void TDelete(Home t)
        {
            _homeDal.Delete(t);
        }

        public Home TGetByID(int id)
        {
            return _homeDal.GetById(id);
        }

        public List<Home> TGetList()
        {
            return _homeDal.GetList();
        }

        public void TUpdate(Home t)
        {
            _homeDal.Update(t);
        }
    }
}
