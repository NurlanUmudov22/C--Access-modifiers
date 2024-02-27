

using Csharp_Const_Readonly_Access_modifiers.Models;
using Csharp_Const_Readonly_Access_modifiers.Services;

namespace Csharp_Const_Readonly_Access_modifiers.Controllers
{
    internal class EmployeeController
    {

        public EmployeeService employeeService;

        public EmployeeController()
        {

             employeeService = new EmployeeService();

        }




        public void GetAll()
        {          

            var result = employeeService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname);
            }

        }


        public void GetAllByAge()
        {
            
            var employees = employeeService.GetAll();

            var result = employeeService.GetAllByAge(employees, 30);

            foreach (var item in result)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.age);
            }

        }



        public void GetCountByAge()
        {
            Console.WriteLine("Add first age:");
            int firstAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Add last age:");
            int lastAge = int.Parse(Console.ReadLine());

            int count = employeeService.GetCountByAge(employeeService.GetAll(), firstAge, lastAge);
            Console.WriteLine(count);
        }


        public void GetSumOfAges()
        {
            int sumOfAge = employeeService.SumOfAge(employeeService.GetAll());
            Console.WriteLine(sumOfAge);
        }


        public void GetAllByCheckedEmail()
        {
            Console.WriteLine("Add your text:");
            string str = Console.ReadLine();

            var employees = employeeService.GetAll();

            Employee[] checkedEmployees = employeeService.GetAllByCheckedEmail(employees, str);

            foreach (var item in checkedEmployees)
            {
                Console.WriteLine(item.name + " " + item.surname + " " + item.email );
            }
        }

    }
}
