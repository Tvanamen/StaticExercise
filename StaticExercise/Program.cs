using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a tempeture in Fahrenheit");
           var fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your temp before conversion was {fahrenheit}");
           //TempConverter.FahrenheitToCelsius(fahrenheit);
           Console.WriteLine($"Your temp after conversion is {TempConverter.FahrenheitToCelsius(fahrenheit)}");
            Console.WriteLine("Please enter a tempeture is Celsius");
            var celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your temp before conversion was {celsius}");
            //TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"Your temp after conversion is {TempConverter.CelsiusToFahrenheit(celsius)}");
        }
    }
}
