/*This program prompts the user for the number of days they will be working
and returning the amount they will earn for each day.*/
using System;
using System.Globalization;

namespace cosc_1436_lab_05_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPay = 0;
            double pay = .1;
            Console.WriteLine("Please enter the number of days you will be working: ");
            var numberOfDays = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Day       Pay");
            Console.WriteLine("=============");

            for(int i = 1; i <= numberOfDays; i++)
            {
                pay *= 2;
                totalPay += pay;
                Console.WriteLine($"{i}      {pay}");
            }
            
            Console.WriteLine($"Your total pay is { totalPay.ToString("{0:C2}", CultureInfo.CurrentUICulture) }");
        }
    }
}