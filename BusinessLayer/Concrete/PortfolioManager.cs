using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Tadd(Portfolio t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new System.NotImplementedException();
        }

        public Portfolio TGetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            throw new System.NotImplementedException();
        }
    }
}
