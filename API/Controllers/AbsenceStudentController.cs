using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbsenceStudentController : ControllerBase
    {
        private readonly IAbsenseCaseService _service;

        public AbsenceStudentController(IAbsenseCaseService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AbsenceCaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }
    }
}
