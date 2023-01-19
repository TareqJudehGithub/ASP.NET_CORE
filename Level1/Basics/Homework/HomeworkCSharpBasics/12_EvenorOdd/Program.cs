///<summary>
/// This program takes two integer inputs from the user, checks if both inputs are even or odd, and returns a bool value.
/// </summary>
namespace _12_EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool result = IsEvenorOdd(num1, num2);
            Console.WriteLine(result);



        }

        // static method
        static internal bool IsEvenorOdd(int num1, int num2)
        {
            bool result = default;

            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                result = true;
            }
            else if (num1 % 2 != 0 && num2 % 2 != 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}