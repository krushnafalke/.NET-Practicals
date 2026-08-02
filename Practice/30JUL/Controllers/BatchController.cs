using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _30JUL.Models;

namespace _30JUl.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class BatchController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBatches()
        {
            var batches = new List<Batch>
            {
                new Batch{Id = 1111, BatchName = "C#"},
                new Batch {Id= 1112, BatchName = "Asp.net"}
            };
            return Ok(batches);
        }
    }
}