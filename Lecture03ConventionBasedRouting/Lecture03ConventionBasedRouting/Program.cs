var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name:"defaul",
    pattern: "{controller=Home}/{action=About}/{id?}");

app.Run();
