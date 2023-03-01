using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakingDisorderDetailsSecondController : ControllerBase
    {
        private readonly ISpeakingDisorderDetailsSecondService _service;

        public SpeakingDisorderDetailsSecondController(ISpeakingDisorderDetailsSecondService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _service.GetById(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetBySpeakingDisorderId(int speakingDisorederId)
        {
            return Ok(await _service.GetBySpeakingDisorderId(speakingDisorederId));
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] SpeakingDisorderDetailsSecond model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SpeakingDisorderDetailsSecond model)
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

        [HttpDelete]
        public async Task<IActionResult> DeleteBySpeakingDisorderId(int speakingDisorederId)
        {
            return Ok(await _service.DeleteBySpeakingDisorderId(speakingDisorederId));
        }
    }
}
