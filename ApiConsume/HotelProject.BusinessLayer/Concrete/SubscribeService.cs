using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeService : ISubscribeDal
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeService(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void Delete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe GetById(int id)
        {
           return _subscribeDal.GetById(id);
        }

        public List<Subscribe> GetList(Subscribe t)
        {
            return _subscribeDal.GetList(t);
        }

        public void Insert(Subscribe t)
        {
           _subscribeDal.Insert(t);
        }

        public void Update(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}
