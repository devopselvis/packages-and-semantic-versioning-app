using System;
using MickeysAwesomePackage;

namespace MyCliApp
{
    class Program
    {
        static void Main(string[] args)
        {
        var addResult = Calculator.Add(2, 3);
        Console.WriteLine($"2 + 3 = {addResult}");

        var divideResult = Calculator.Divide(10, 2);
        Console.WriteLine($"10 / 2 = {divideResult}");

        try
        {
            var divideResultZero = Calculator.Divide(10, 0);
            Console.WriteLine($"10 / 0 = {divideResultZero}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("10 / 0 = Error: " + ex.Message); 
        }

        }
    }
}