using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trydotnet50features.Models;

namespace trydotnet50features.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        
        public IActionResult Get()
        {
            EmployeeModel empModel = new EmployeeModel
                {
                Name = "Rama",
                Designation = "Architect",
                Department = "New Initiatives"
            };
            //Since init only - the below code wont work
            //empModel.Name = "Krishna";
           

            return Ok(empModel);
        }
        [HttpGet("/api/emprecord")]
        public IActionResult GetEmployee()
        {
            EmployeeRecord empRecord = new EmployeeRecord("Ratheesh", "New Initiatives", "Architect");
            return Ok(empRecord);
        }
        [HttpGet("/api/recordinherit")]
        public IActionResult GetInhertitedPerson()
        {
            SalesPerson salesPerson = new SalesPerson
            {
                age="20",
                name="tim",
                Designation="executive"
            };

            SalesPerson sperson1 = salesPerson with { Designation = "manager" };

            //salesPerson.age = "20";
            //salesPerson.name = "Tim";
            //salesPerson.Designation = "sales executive";
            return Ok(sperson1);
        }
    }
}
