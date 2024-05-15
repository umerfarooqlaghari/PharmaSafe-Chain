using Microsoft.AspNetCore.Mvc;
using ProjectLearn.Interfaces;
using ProjectLearn.Models.UserManagementModels;
using ProjectLearn.Models.UserManagementModels.EmployeeManagement;

namespace ProjectLearn.Controllers.EmployeeControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _EmployeeRepository;

       public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<EmployeeDirectoryTable>))]
        public IActionResult GetEmployees()
        {

            var employees = _EmployeeRepository.GetEmployees();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(employees);
        }
    }
}
