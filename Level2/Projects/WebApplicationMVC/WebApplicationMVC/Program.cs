namespace WebApplicationMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Services
            var builder = WebApplication.CreateBuilder(args);


            var app = builder.Build();

            // Middleware(s)
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}