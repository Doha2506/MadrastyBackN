using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingCourseController : ControllerBase
    {
        private readonly ITrainingCourseService _service;

        public TrainingCourseController(ITrainingCourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetByEmployeeId(int employeeId)
        {
            return Ok(await _service.GetByEmployeeId(employeeId));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] TrainingCourseViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

    }
}
