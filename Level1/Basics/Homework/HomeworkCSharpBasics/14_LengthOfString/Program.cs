/// <summary>
/// This program calculates the length of a given string without using Length method.
/// </summary>
namespace _14_LengthOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string sentence = Console.ReadLine();

            Console.WriteLine($"The length of the string is: {LengthOfString(sentence)}");
        }

        // static method
        static internal int LengthOfString(string sentence)
        {
            int stringCounter = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                stringCounter++;
            }
            return stringCounter;
        }
    }
}