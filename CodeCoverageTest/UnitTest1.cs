using CodeCoverageEg.Controllers;
using CodeCoverageEg.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodeCoverageTest
{
    public class Tests
    {
        
        public static ValuesController obj;
        
        [SetUp]
        public void Setup()
        {
            obj = new ValuesController();
        }

        [Test]
        public void TestGetAllEmployees()
        {
            //new test method added
            List<Employee> actualresult = Employee.getEmployees();
            int numberofemployees = actualresult.Count;
            int expectedemployees = 3;
            Assert.AreEqual(expectedemployees, numberofemployees);

        }

        [Test]
        public void TestGetValuesMethod()
        {
             var actionResult = obj.getAllEmployees();
            Employee e = new Employee() { Eid = 1, Ename = "Shrivalli", Salary = 23090 };
            //Assert
            var result = actionResult.Result as OkObjectResult;
            var obj1 = result.Value as List<Employee>;
            Assert.AreEqual("Shrivalli", obj1[0].Ename);


        }

        /*[Test]
        public void TestGetValuesMethod()
        {
            int id = 1;
            var actionResult = obj.getEmpById(id);
            Employee e = new Employee() { Eid = 1, Ename = "Shrivalli", Salary = 23090 };
            //Assert
            var result = actionResult.Result as OkObjectResult;
            Employee obj1 = result.Value as Employee;
            Assert.AreEqual("Shrivalli", obj1.Ename);


        }

        [Test]
        public void TestgetEmppBySalController()
        {
            var actionResult = obj.getEmpBySal(24000);
            var result = actionResult.Result as OkObjectResult;
            int count = Convert.ToInt32(result.Value);
            Assert.AreEqual(2, count);
        }*/

    }

    }

