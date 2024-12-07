using System;
using CalculatorCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatorApp
{
    public class Calculator
    {

        public static void RunCalculator()
        {
            float num1 = 0; //assigned zero to variable num1
            float num2 = 0;


            string restartCheck; //declared the variable restartcheck

            Console.WriteLine("input your first number , and then press Enter");
            string numinput1 = Console.ReadLine();

            var chechNum1 = float.TryParse(numinput1, out num1);

            if (!chechNum1)
            {
                Console.WriteLine("Invalid input.Please enter an integer value: ");
                numinput1 = Console.ReadLine();
            }

            Console.WriteLine("input your second number , and then press Enter");
            string numinput2 = Console.ReadLine();

            var chechNum2 = float.TryParse(numinput2, out num2);
            if (!chechNum2)
            {
                Console.WriteLine("Invalid input.Please enter an integer value: ");
                numinput1 = Console.ReadLine();
            }

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("Your option? ");


            switch (Console.ReadLine())  //using switch conditional statement 
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
                    while (num2 == 0) //iteration or the while loop
                    {

                        Console.WriteLine("Enter a non-zero denominator: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your answer is : {num1} / {num2} = " + (num1 / num2));
                    break;
            } 

            Console.Write("Type 'yes' to restart the application  ");
            restartCheck = Console.ReadLine(); //user input
            if (restartCheck == "yes") //if statement
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");


                //Calculator1.Calc();
                RunCalculator();

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
