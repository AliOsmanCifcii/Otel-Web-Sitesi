using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private IServiceService _serviceService;

        public ServiceManager(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public void TDelete(Service t)
        {
            _serviceService.TDelete(t);
        }

        public Service TGetById(int id)
        {
            return _serviceService.TGetById(id);
        }

        public List<Service> TGetList(Service t)
        {
            return _serviceService.TGetList(t);
        }

        public void TInsert(Service t)
        {
            _serviceService.TInsert(t);
        }

        public void TUpdate(Service t)
        {
            _serviceService.TUpdate(t);
        }
    }
}
