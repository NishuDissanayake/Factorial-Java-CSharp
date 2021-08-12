using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: "); //negetive numbers do not have factorial
            int number = int.Parse(Console.ReadLine());

            long value = factorialCalculation(number);
            Console.WriteLine("Factorial of " + number + " is " + value);

            Console.ReadLine();
        }

        //This function calculates the factorial from a given number
        public static long factorialCalculation(int num)
        {
            long factorial = 0; //declare the variable to return

            if (num == 0 || num == 1)
            {
                return num; //return fatorial value as 0 or 1 when the given value is 0 or 1
            }
            else
            {
                return factorial = num * (factorialCalculation(num - 1)); //calculate faorial until the value reaches 0 or 1
            }
        }
    }
}
