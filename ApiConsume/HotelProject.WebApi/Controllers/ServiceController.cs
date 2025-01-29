using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public ActionResult ServiceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public ActionResult AddService(Service Service)
        {
            _serviceService.TInsert(Service);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetById(id);
            _serviceService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public ActionResult UpdateService(Service Service)
        {
            _serviceService.TUpdate(Service);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetService(int id)
        {
            var value = _serviceService.TGetById(id);

            return Ok(value);
        }
    }
}
