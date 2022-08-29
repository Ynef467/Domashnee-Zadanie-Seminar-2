// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            
            if(number > 100 & number < 1000)
            {

            // int firstNum = (number / 100); //первая цифра
            
            int secondNum = (number / 10 % 10); //вторая цифра

            // int thirdNum = (number % 10); //третья цифра

            System.Console.WriteLine($"Number {secondNum}");
            
            }
            else
            {
            System.Console.WriteLine($"wrong number");    
            }
        }
    }
}
