using NUnit.Framework;
using CodeCoverageEg.Controllers;
using CodeCoverageEg.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}