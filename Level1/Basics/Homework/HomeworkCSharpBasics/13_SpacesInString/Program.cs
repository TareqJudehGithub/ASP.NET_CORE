///<summary>
/// This program calculates how many spaces in a sentence string using for loops.
/// </summary>

namespace _13_SpacesInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string sentence = Console.ReadLine();

            Console.WriteLine($"\"{sentence}\" contains {SpaceCalculator(sentence)} spaces.");
        }

        // static method
        static internal int SpaceCalculator(string sentence)
        {
            int spaceCounter = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    spaceCounter++;
                }
            }
            return spaceCounter;
        }
    }
}