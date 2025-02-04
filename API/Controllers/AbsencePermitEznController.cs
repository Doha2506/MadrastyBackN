﻿using BusinessLogic.Abstractions;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AbsencePermitEznController : ControllerBase
    {
        private readonly IAbsencePermitEznService _service;

        public AbsencePermitEznController(IAbsencePermitEznService service)
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
        public async Task<IActionResult> GetByEmployeeId(int emploeeId)
        {
            var result = await _service.GetByEmployeeId(emploeeId);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByDepartmentId(int departmentId)
        {
            var result = await _service.GetByDepartmentId(departmentId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AbsencePermitEznViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _service.Save(model));
            }
            return Ok(new ServiceResponse("Validation Error"));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AbsencePermitEznViewModel model)
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
