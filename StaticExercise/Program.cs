namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double int1 = TempConverter.CelsiusToFahrenheit(20);
            double int2 = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"20 Celcius is {int1} in Fahrenheri and 68 Fahrenhei is {int2} in Celcius.");
        }
    }
}
