using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {

        public static void RunCalculator()
        {
            float num1 = 0;
            float num2 = 0;


            string restartCheck;

            Console.WriteLine("input your first number , and then press Enter");
            num1 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("input your second number , and then press Enter");
            num2 = (float)Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option? ");


            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your answer is : {num1} + {num2} = " + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine($"Your answer is : {num1} - {num2} = " + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine($"Your answer is : {num1} * {num2} = " + (num1) * (num2));
                    break;

                case "d":
                    while (num2 == 0)
                    {

                        Console.WriteLine("Enter a non-zero denominator: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your answer is : {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Type 'yes' to restart the application  ");
            restartCheck = Console.ReadLine();
            if (restartCheck == "yes")
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");


                CalculatorCore.Calculator1.Calc();

            }
            else
            {
                Console.Write("Press any key to close app");
                Environment.Exit(0);
            }
            Console.WriteLine("--------------------------");




















        }
    }
}
