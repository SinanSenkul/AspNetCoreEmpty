var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();   //configuration to use static files in wwwroot
app.UseRouting();        //Routing configuration
app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}"
    );
app.Run();

