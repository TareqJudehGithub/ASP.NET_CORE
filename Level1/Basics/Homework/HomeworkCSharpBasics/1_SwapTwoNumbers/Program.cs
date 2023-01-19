///<summary>
/// This program swap values of two int variables a and b.
/// </summary>
namespace _1_SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"{nameof(a)} = {a}");
            Console.WriteLine($"{nameof(b)} = {b}");
        }
    }
}