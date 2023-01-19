///<summary>
/// This program outputs the longest word in a given string.
/// </summary>
namespace _3_LongestString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Write a C# Sharp Program to display the following pattern using the alphabet";
            string[] words = sentence.Split(" ");

            int maxLetters = 0;
            string longestWord = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i].Length);

                if (words[i].Length > maxLetters)
                {
                    maxLetters = words[i].Length;
                    longestWord = words[i];
                }
            }
            Console.WriteLine($"'{longestWord}' is the longest word.");

        }
    }
}