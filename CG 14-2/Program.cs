using System;

namespace CalcAssign14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Create a simple calculator that asks the user to input two different numbers and whether they want to add, 
                //subtract, multiple or divide them.

                //Program  for the variables first number, second number, answer and operation. 
                double firstnumber = 0;
                double secondnumber = 0;
                double answer = 0;
                string operation = " ";

                //Ask the user to input the numbers.
                Console.WriteLine("Welcome to a simple calculator. Please enter two numbers with an operator (+, -, *,/) " +
                    "followed by the enter key. The format should be NUMBER, OPERATOR, NUMBER with spaces in between each entry.");

                //Print the user input to the console.
                string input = Console.ReadLine();

                var parts = input.Split(" ");

                if (parts != null)
                {
                    firstnumber = Convert.ToDouble(parts[0]);
                    operation = parts[1];
                    secondnumber = Convert.ToDouble(parts[2]);
                }



                //Below calculates and prints the answer to the console depending on which operator chosen as an equation.

                //Checks if the variable to the cases, if not the default is selected. Break has to be used to exit the curly brackets.
                switch (operation)
                {
                    case "*":
                        answer = Operators.Multiply(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " * " + secondnumber + " = " + answer);
                        break;
                    case "/":     
                        answer = Operators.Divide(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " / " + secondnumber + " = " + answer);
                        if (secondnumber == 0)
                        {
                            Console.WriteLine("Cannot divide by 0, please try again.");
                        }
                        break;
                    case "+":
                        answer = Operators.Addition(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " + " + secondnumber + " = " + answer);
                        break;
                    case "-":
                        answer = Operators.Minus(firstnumber, secondnumber);
                        Console.WriteLine(firstnumber + " - " + secondnumber + " = " + answer);
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Incorrect format. Must be number, operator, number with spaces in between each.");
            }
            Console.ReadLine();

        }
    }
}