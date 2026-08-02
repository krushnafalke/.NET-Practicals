using _29JUL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _29JUL.Models;

namespace _29JUL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getVehicles());
        }
        [HttpGet("{vehicleid}")]

        public IActionResult GetByVehicleId(int vehicleid)
        {
            var vehicle = _service.getVehicle(vehicleid);
            if(vehicle == null)
              return NotFound("Employee with id not found");

            return Ok(vehicle);
        }
        [HttpGet("{vehiclename}")]
        public IActionResult GetByName(string VehicleName)
        {
            var vehicle = _service.getVehicleName(VehicleName);
            if(vehicle == null)
              return NotFound("Employee with name not found");

            return Ok(vehicle);
        }
        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {
            var res = _service.addVehicle(vehicle);
            return Ok(res);
        }


    }
}