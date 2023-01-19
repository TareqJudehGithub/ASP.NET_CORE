///<summary>
/// This program takes a circle radius user input value, and calculates the perimeter and area.
/// </summary>

namespace _11_CirclePerimeterArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the circle radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            const double PI = 3.14159d;

            double perimeter = (2 * PI * radius);
            double area = PI * Math.Pow(radius, 2);

            Console.WriteLine($"Circle perimeter = {perimeter:N2}");
            Console.WriteLine($"Circle area = {area:N2}");
        }
    }
}
