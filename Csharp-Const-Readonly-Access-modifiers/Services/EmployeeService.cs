using Csharp_Const_Readonly_Access_modifiers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Const_Readonly_Access_modifiers.Services
{
    internal class EmployeeService : Employee
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                id = 1,
                name = "Employee1",
                surname = "Employev1",
                address = "Baki1",
                email = "temploye1@gmail.com",
                age = 32
            };



            Employee employee2 = new()
            {
                id = 2,
                name = "Employee2",
                surname = "Employev2",
                address = "Baki2",
                email = "temploye2@gmail.com",
                age = 29
            };



            Employee employee3 = new()
            {

                id = 3,
                name = "Employee3",
                surname = "Employev3",
                address = "Baki3",
                email = "employe3@gmail.com",
                age = 39
            };



            Employee employee4 = new()
            {
                id = 4,
                name = "Employee4",
                surname = "Employev4",
                address = "Baki4",
                email = "employe4@gmail.com",
                age = 52
            };
            Employee[] employers = { employee1, employee2, employee3, employee4 };
            return employers;
        }


        public Employee[] GetAllByAge(Employee[] employees, int age)
        {           
            return employees.Where(m => m.age > age).ToArray();
        }
        

        public int GetCountByAge(Employee[] employees, int firstAge, int lastAge) 
        {
               return employees.Where(m=> m.age > firstAge && m.age < lastAge).Count();
        }


        public int SumOfAge(Employee[] employees)
        {
            return employees.Sum(m => m.age);
        }


        public Employee[] GetAllByCheckedEmail(Employee[] employees, string str)
        {
            return employees.Where(m => m.email.StartsWith(str)).ToArray();
        }



    }
}
