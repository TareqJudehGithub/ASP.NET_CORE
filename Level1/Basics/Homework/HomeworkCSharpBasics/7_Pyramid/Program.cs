/// <summary>
/// This program draws a pyramid using asterisk symbols.
/// </summary>
namespace _7_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int levels, block, space, y;
            string star = string.Empty;

            Console.Write("enter the pyramid number of levels: ");
            levels = Convert.ToInt32(Console.ReadLine());
            for (block = 1; block <= levels; block++)
            {
                for (space = 1; space < levels - block + 1; space++)
                {
                    Console.Write(" ");
                }
                for (y = 1; y <= block; y++)
                {
                    Convert.ToString(block);
                    star += block;
                    star = "*";
                    Console.Write(star);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}