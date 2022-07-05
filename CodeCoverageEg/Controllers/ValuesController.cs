using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using PipelineDemo.Models;
using System.Linq;

namespace PipelineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Employee> employees = Employee.getEmployees();

        public ActionResult<List<Employee>> getAllEmployees()
        {
            return Ok(employees);
        }
        public ActionResult<Employee> getEmpById(int id)
        {
            Employee e=employees.Where(x=>x.Eid==id).SingleOrDefault();
            return Ok(e);
        }
    }
}
