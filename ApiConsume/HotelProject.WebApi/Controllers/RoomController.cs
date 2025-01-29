using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public ActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public ActionResult AddRoom(Room Room)
        {
            _roomService.TInsert(Room);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetById(id);
            _roomService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public ActionResult UpdateRoom(Room Room)
        {
            _roomService.TUpdate(Room);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult GetRoom(int id)
        {
            var value = _roomService.TGetById(id);

            return Ok(value);
        }
    }
}
