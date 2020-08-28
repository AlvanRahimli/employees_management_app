using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace employee_management_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("")]
        public Task<IActionResult> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}