using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentTrackingController : ControllerBase
    {
        private readonly IStudentTrackingService _service;

        public StudentTrackingController(IStudentTrackingService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int classId, string date)
        {
            return Ok(await _service.Get(classId, date));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByClassIdAndDate(int classId, string date)
        {
            return Ok(await _service.GetByClassIdAndDate(classId, date));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] StudentTrackingViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] StudentTrackingViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Update(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _service.Delete(id));
        }
    }
}
