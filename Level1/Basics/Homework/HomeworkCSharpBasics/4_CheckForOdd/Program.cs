/// <summary>
/// This program searches an array of integer numbers, for an odd value, and returns a boolean value.
/// </summary>

namespace _4_CheckForOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 7, 8, 6 };
            Console.WriteLine($"Check if an array contains an odd number? {IsOddNumber(numbers)}");
        }
        // Static methods
        static internal bool IsOddNumber(params int[] numbers)
        {
            bool isOdd = default;

            for (int i = 0; i < numbers.Length; i++)
            {
                isOdd = numbers[i] % 2 != 0 ? true : false;
                if (isOdd) break;
            }
            return isOdd;
        }
    }
}
