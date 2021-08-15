using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelcius(double CTemp)
        {
            return (CTemp - 32) * 5 / 9;
        }

        public static double CelciusToFarenheit(double FTemp)
        {
            return ((FTemp * 9) / 5) + 32;
        }
    }

}
