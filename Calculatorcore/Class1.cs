using System;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorCore
{
    public class Calculator1
    {
        JsonWriter writer;
        public Calculator1() //constructor
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }

        public double DoOperation(double num1, double num2, string type)
        {

            double result = double.NaN; //NaN is a value that is not a number
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(num1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(num2);
            writer.WritePropertyName("Operation");


            switch (type)
            {
                case "a":
                    result = num1 + num2;
                    writer.WriteValue("Add");
                    break;
                case "s":
                    result = num1 - num2;
                    writer.WriteValue("Subtract");
                    break;
                case "m":
                    result = num1 * num2;
                    writer.WriteValue("Multiply");
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;

                    }
                    writer.WriteValue("Divide");
                    break;
            }
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();
            return result;

        }
        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
        public static void Calc()
        {

            bool endApp = false;
            while (!endApp)
            {
                string numinput1 = "";
                string numinput2 = "";
                double result = 0;



                Console.WriteLine("input your first number , and then press Enter");
                numinput1 = Console.ReadLine();

                double numb1 = 0;
                while (!double.TryParse(numinput1, out numb1))
                {
                    Console.WriteLine("Invalid input.Please enter an integer value: ");
                    numinput1 = Console.ReadLine();
                }


                Console.WriteLine("input your second number , and then press Enter");
                numinput2 = Console.ReadLine();

                double numb2 = 0;
                while (!double.TryParse(numinput2, out numb2))
                {
                    Console.WriteLine("Invalid input.Please enter an integer value: ");
                    numinput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("Your option? ");

                string type = Console.ReadLine();

                try
                {
                    var calculator = new Calculator1();
                    result = calculator.DoOperation(numb1, numb2, type);
                    if (double.IsNaN(result)) //checking cases where a non integer is inputed
                    {
                        Console.WriteLine("Mathematical error.\n");

                    }
                    else
                    {
                        Console.WriteLine("Your result \n: " + result);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("oops! An eror occured\n:" + ex.Message);
                }
                Console.WriteLine("------------------------------");
                Console.Write("Press any key to close app");
                Environment.Exit(0);

                endApp = true;
            }
        }

    }
}





