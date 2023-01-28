using EmpManage.Models.Implementation;
using EmpManage.Models.Interfaces;

var builder = WebApplication.CreateBuilder(args);

#region Services
// register/add MVC service
builder.Services.AddMvc(options => options.EnableEndpointRouting = false); // disable routing in case we using app.UseMvcWithDefaultRoute();

// Register/Add dependency injection
builder.Services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
#endregion

var app = builder.Build();

#region Middleware(s)

if (app.Environment.IsDevelopment())
// If we r in development phase, add app.UseDeveloperExceptionPage();
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles(); // enables adding files

app.UseMvcWithDefaultRoute();  // enables MVC Routing    /port#/home/index
                               // home  means the HOMEController class in Controllers
                               // index is the action name in HomeController class


app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "Default",
        template: "{ controller = Home}/{action = Index}"
        );
});
// app.MapGet("/", () => "Hello World!");


app.Run();
#endregion


