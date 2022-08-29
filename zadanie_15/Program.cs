// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет





using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            
            if(number > 0 & number < 8)
            {
                if(number > 0 & number < 6)
                {
                    System.Console.WriteLine($"No");
                }
                else
                {
                   System.Console.WriteLine($"Yes"); 
                }
            }
            else
            {
            System.Console.WriteLine($"wrong number");    
            }
        }
    }
}
