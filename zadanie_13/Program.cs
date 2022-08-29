// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6



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
            
            // int secondNum = (number / 10 % 10); //вторая цифра

            int thirdNum = (number % 10); //третья цифра
            
            System.Console.WriteLine($"Number {thirdNum}");
            
            }
            if (number < 100)
            {
              System.Console.WriteLine($"wrong number");  
            }
            if(number > 1000)
            {
                string numberText = Convert.ToString(number);

                System.Console.WriteLine($"Number {numberText[2]}");
            }
            
        }
    }
}
