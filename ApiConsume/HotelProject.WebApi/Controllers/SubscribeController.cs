using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public ActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public ActionResult AddSubscribe(Subscribe Subscribe)
        {
            _subscribeService.TInsert(Subscribe);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            _subscribeService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public ActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _subscribeService.TUpdate(Subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);

            return Ok(value);
        }
    }
}
