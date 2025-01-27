using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffDal
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Delete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff GetById(int id)
        {
           return _staffDal.GetById(id);
        }

        public List<Staff> GetList(Staff t)
        {
            return _staffDal.GetList(t);
        }

        public void Insert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void Update(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
