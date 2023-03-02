using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripDetailsController : ControllerBase
    {
        private readonly ITripDetailsService _service;

        public TripDetailsController(ITripDetailsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetByTripId(int tripId)
        {
            return Ok(await _service.GetByTripId(tripId));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] TripDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

    }
}
