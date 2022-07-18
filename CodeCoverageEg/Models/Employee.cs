using System.Collections.Generic;

namespace CodeCoverageEg.Models
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public float Salary { get; set; }
        public Employee() { }
        public Employee(int eid,string ename,float sal)
        {
            Eid = eid;
            Ename = ename;
            Salary = sal;
        }

        public static List<Employee> emps = new List<Employee>();
        public static List<Employee> getEmployees()
        {
            //Method tested
            emps.Add(new Employee(1, "Shrivalli", 23090));
            emps.Add(new Employee(2, "Shyam", 25000));
            emps.Add(new Employee(3, "Rachna", 21000));
            emps.Add(new Employee(4, "Rishi", 18000));
            return emps;
        }
     }
}
