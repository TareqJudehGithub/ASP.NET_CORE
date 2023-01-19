/// <summary>
/// This program compares two strings and return and minimum value between the two.
/// </summary>

namespace _9_MinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string firstNum = Console.ReadLine();

            Console.Write("Enter second number: ");
            string secondNum = Console.ReadLine();

            Console.WriteLine($"\n{MinValue(firstNum, secondNum)}");
        }

        // static methods
        static internal string MinValue(string num1, string num2)
        {
            string result = string.Empty;

            if (num1.Min() < num2.Min())
            {
                result = $"{num1} is the minimum value";
            }
            else if (num1.Min() > num2.Min())
            {
                result = $"{num2} is the minimum value";
            }
            else
            {
                result = "Both values are equal.";
            }

            return result;
        }
    }
}