using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempF)
        {
            return (tempF - 32) * (5.0 / 9.0);
        }
        public static double CelsiusToFahrenheit(double tempC)
        {
            return tempC * (9.0 / 5.0) + 32;
        }
    }
}
