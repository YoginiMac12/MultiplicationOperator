using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum = 0, i;
            Console.WriteLine("Enter the Number1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num1; i++)
            {
                sum = sum + num2;
            }
            Console.WriteLine("Multiplication of two numbers: " + sum);
        }
    }
 }


