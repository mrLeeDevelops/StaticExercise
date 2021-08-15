using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var farenheit = TempConverter.CelciusToFarenheit(37);
            var celcius = TempConverter.FarenheitToCelcius(212);
            Console.WriteLine($"The Farenheit Temperature Converted From Celcius is {farenheit} Degrees F.");
            Console.WriteLine($"The Celcius Temperature Converted From Farenheit is {celcius} Degrees C.");
        }
    }
}
