using Microsoft.AspNetCore.Mvc;
using Test_Assignment_3.DTO;

namespace deleteMe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost]
        public async Task <bool> CreateEmployee(CreateEmployeeDTO employee)
        {
            return true;
        }
    }
}