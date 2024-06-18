var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





app.UseRouting();

app.UseEndpoints(endpoints => {
     endpoints.MapGet("/Home", async (context)=> {
        await context.Response.WriteAsync("Hello World! Get");
        });

    endpoints.MapPost("/Home", async (context) => {
        await context.Response.WriteAsync("Hello World! Get");
    });
});


app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello World! Get");
});
//app.Map("/", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World! Get");
//app.MapPost("/Home", () => "Hello World! Post");
//app.MapDelete("/Home", () => "Hello World! Delete");
//app.MapPut("/Home", () => "Hello World! Put");

app.Run();
