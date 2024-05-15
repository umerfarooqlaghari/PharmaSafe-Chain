using Microsoft.AspNetCore.Mvc;
using ProjectLearn.Interfaces;
using ProjectLearn.Models.UserManagementModels.DoctorManagement;

namespace ProjectLearn.Controllers.DoctorControllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }


        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DoctorDirectoryTable>))]
        public IActionResult GetDoctors()
        {

            var doctors = _doctorRepository.GetDoctors();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(doctors);
        }
    }
}
