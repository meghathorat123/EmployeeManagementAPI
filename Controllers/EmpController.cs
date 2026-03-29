using EmpManagement.Services;
using EmpManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpManagement.Repos;

namespace EmpManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {

        private readonly IEmployeeService _service;

        public EmpController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _service.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("GetEmployeeById/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _service.GetEmployeeById(id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _service.AddEmployee(employee);
            if (result)
                return Ok("Employee added successfully.");
            return StatusCode(500, "An error occurred while adding the employee.");
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _service.UpdateEmployee(employee);
            if (result)
                return Ok("Employee updated successfully.");
            return StatusCode(500, "An error occurred while updating the employee.");
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _service.DeleteEmployee(id);
            if (result)
                return Ok("Employee deleted successfully.");
            return StatusCode(500, "An error occurred while deleting the employee.");

        }
    }
}

