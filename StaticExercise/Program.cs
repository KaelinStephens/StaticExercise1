using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int tempscale = TempScale("Is your temperature in Celcius or Fahreneit?");
            TempNumber(tempscale);
        }
        public static int TempScale(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                int choice;
                Console.WriteLine("1: Celcius");
                Console.WriteLine("2: Fahrenheit");
                string input = Console.ReadKey().KeyChar.ToString();

                if (Int32.TryParse(input, out choice))
                {
                    // check if number is between 0 and choices.Length
                    if (choice == 1)
                    {
                        Console.WriteLine($"Celcius");
                        return choice;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine($"Fahrenheit");
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine($"You must choose between 1 and 2");
                        continue;
                    }
                    //   if yes return number
                    //   if no output error and continue

                }
               
            }

        }

        public static void TempNumber(int tempscale)
        {
            Console.WriteLine("What is the temperature to be converted?");
            string input = Console.ReadLine();

            double convTemp;
            if (Double.TryParse(input, out convTemp))
            {
                // check if number is between 0 and choices.Length
                if (tempscale == 1)
                {
                    double newTemp = TempConverter.CelsiusToFahrenheit(convTemp);
                    Console.WriteLine($"{input} degrees C is {newTemp} degrees F.");

                }
                else
                {
                    double newTemp = TempConverter.FahrenheitToCelsius(convTemp);
                    Console.WriteLine($"{input} degrees F is {newTemp} degrees C.");
                }

            }
         
            
        }
    }
}
