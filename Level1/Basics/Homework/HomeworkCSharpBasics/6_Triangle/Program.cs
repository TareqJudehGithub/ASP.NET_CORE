/// <summary>
/// This program takes the user integer number input, and draws a right-angle triangle using the asterisk symbol.
/// </summary>

namespace _6_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            global::System.Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            string star = "*";

            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
        }
    }
}