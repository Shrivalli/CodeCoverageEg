﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using CodeCoverageEg.Models;
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
    }
}
