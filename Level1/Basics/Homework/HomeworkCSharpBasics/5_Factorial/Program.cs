/// <summary>
/// This program takes the user input integer number, and calculates it's factorial value.
/// </summary>
/// 
namespace _5_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nThe Factorial of {userInput} is {Factorial(userInput)}");
        }

        // Static methods
        static internal int Factorial(int userInput)
        {
            int factorialValue = userInput;

            for (int i = 1; i < userInput; i++)
            {
                factorialValue *= (userInput - i);
            }
            return factorialValue;
        }
    }
}