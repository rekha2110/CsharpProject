using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetManagement.BAL.Services;
using TimeSheetManagement.Entity.Models;

namespace TimeSheetManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private AdminServices _adminServices;
        public AdminController(AdminServices adminServices)
        {
            _adminServices = adminServices;
        }
        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _adminServices.GetEmployees();
        }
        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            _adminServices.AddEmployee(employee);
            return Ok("Employee created successfully!!");
        }
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int EmpID)
        {
            _adminServices.DeleteEmployee(EmpID);
            return Ok("Movie deleted successfully!!");
        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _adminServices.UpdateEmployee(employee);
            return Ok("Employee updated successfully!!");
        }
     }
}
