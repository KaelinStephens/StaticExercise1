using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {

        public static double FahrenheitToCelsius(double tempF)
        {
            double fToC = (tempF - 32) * 5 / 9;
            return fToC;
        }
        public static double CelsiusToFahrenheit(double tempC)
        {
            double cToF = (tempC * 9 / 5) + 32;
            return cToF;
        }
    }
}
