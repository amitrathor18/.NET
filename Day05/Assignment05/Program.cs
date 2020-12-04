using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    class Program
    {
        static void Main1(string[] args)
        {
        }
    }
}

namespace EmployeeArray
{
    class Program
    {
        static void Main()
        {
            object[] arr = new object[2];

            Employee e = new Employee();

            e.EmpId = 1;
            e.Name = "Amit";
            e.Salary = 50000;


            Employee e1 = new Employee();

            e.EmpId = 2;
            e.Name = "Mohit";
            e.Salary = 55000;


            arr[0] = e;
            arr[1] = e1;

            foreach (object x in arr)

                Console.WriteLine( x);
            Console.ReadLine();
        }
    }
    class Employee
    {
        private int empId;
        private string name;
        private decimal salary;
        public int EmpId
        {
            set;
            get;
        }
        public string Name
        {
            set;
            get;
        }
        public decimal Salary
        {
            set;
            get;
        }
    }
}
