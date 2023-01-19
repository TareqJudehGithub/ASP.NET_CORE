///<summary>
/// This program takes four numbers as inputs, calculates and prints the average of these numbers.
/// </summary>
namespace _2_CalculateAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double avg = 0;
            int totalNums = 0;

            //  Capture user input, saving it in a variable, and then add it to sum:
            Console.Write("Enter the First number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            sum += firstNum;
            totalNums++;

            Console.Write("Enter the First number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            sum += secondNum;
            totalNums++;

            Console.Write("Enter the First number: ");
            double thirdNum = Convert.ToDouble(Console.ReadLine());
            sum += thirdNum;
            totalNums++;

            Console.Write("Enter the First number: ");
            double fourthNum = Convert.ToDouble(Console.ReadLine());
            sum += fourthNum;
            totalNums++;

            avg = sum / totalNums;

            // output
            Console.WriteLine($"\nThe average of {firstNum}, {secondNum}, {thirdNum}, {fourthNum} is: {avg}");

        }
    }
}