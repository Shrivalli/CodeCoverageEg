using CodeCoverageEg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CodeCoverageEg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Employee> employees = Employee.getEmployees();

        [HttpGet]
        public ActionResult<List<Employee>> getAllEmployees()
        {
            return Ok(employees);
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> getEmpById(int id)
        {
            Employee e=employees.Where(x=>x.Eid==id).SingleOrDefault();
            return Ok(e);
        }

        [HttpGet]
        [Route("GetEmpSal")]
        public ActionResult<int> getEmpBySal(int salmax)
        {
            var result=(from i in employees
                       where i.Salary<salmax
                       select i).ToList();
            return Ok(result.Count);
        }
    }
}
