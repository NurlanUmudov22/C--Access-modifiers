 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Const_Readonly_Access_modifiers
{
    internal class CustomMath
    {
        public int GetSumOfArrayItems(int[] nums) => nums.Where(m => m % 2 == 1).Sum();


        public string CheckNumberByEvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";


        public double SquareOfEvenNumbers(int[] nums) => Math.Pow(nums.Where(m => m % 2 == 0).Sum(),2);


      
        public int MultipleOfNumbers(int n)
        {
            int multiple = 1;
            for (int i = 1;  i <= n; i++)
            {
                multiple *= i;
            }
            return multiple;
        }

































    }
}
