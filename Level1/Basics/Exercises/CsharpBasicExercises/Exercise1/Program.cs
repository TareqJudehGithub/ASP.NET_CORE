namespace Exercise1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercise 1:\n" +
            "Write a C# Sharp program to print Hello and your name in a separate line. \r\n Expected Output :\r\nHello: Alexandra Abramov\r\n\r\n");

        // Solution
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        ExerciseOne(username);

    }


    static internal void ExerciseOne(string username)
    {
        Console.WriteLine($"Hello: {username}");
    }
}
