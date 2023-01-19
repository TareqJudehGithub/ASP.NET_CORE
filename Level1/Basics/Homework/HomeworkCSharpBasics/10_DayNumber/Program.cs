///<summary>
/// This program takes a user integer input from range 1 - 7,  and returns a string day name.
/// </summary>

namespace _10_DayNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = default;
            Console.WriteLine($"{DayName(userInput)}");

        }
        // static method
        static internal string DayName(int userInput)
        {
            string day = string.Empty;
            do
            {
                Console.Write("Please enter a day number: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < 1 || userInput > 7)
                {
                    // If user input is not between 1 and 7, restart program
                    Console.WriteLine("Day number should be between range 1-7\n");
                }
                switch (userInput)
                {
                    case 1:
                        day = "Monday";
                        break;
                    case 2:
                        day = "Tuesday";
                        break;
                    case 3:
                        day = "Wednesday";
                        break;
                    case 4:
                        day = "Thursday";
                        break;
                    case 5:
                        day = "Friday";
                        break;
                    case 6:
                        day = "Saturday";
                        break;
                    case 7:
                        day = "Sunday";
                        break;
                    default:
                        day = "Invalid number entered.";
                        break;
                }
            }
            while (day.Equals("Invalid number entered."));
            return day;
        }
    }
}