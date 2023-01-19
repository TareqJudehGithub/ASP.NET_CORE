///<summary>
/// This program takes a string input, and removes all duplicate characters.
/// </summary>

namespace _15_RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Original string: ");
            string origString = Console.ReadLine();

            Console.WriteLine($"\nAfter removing duplicate characters from the original string:\n{RemoveDuplicateChar(origString)}");
        }

        // static method
        static internal string RemoveDuplicateChar(string userInput)
        {
            string output = string.Empty;
            Char[] letters = new char[userInput.Length];

            for (int i = 0; i < userInput.Length; i++)
            {
                if (!letters.Contains(userInput[i]))
                {
                    letters[i] = userInput[i];
                }

                output = String.Join("", letters);
            }
            return output;
        }
    }
}