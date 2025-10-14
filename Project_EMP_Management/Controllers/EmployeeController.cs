using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_EMP_Management.Data;

namespace Project_EMP_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public EmployeeController(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get() 
        {

            return Ok(dbContext.Employees.ToList());
          
        }
    }
}
