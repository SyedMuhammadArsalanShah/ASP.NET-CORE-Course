var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) => {


    await context.Response.WriteAsync("Welcome by Use Middleware\n");
    await next(context);

});

app.Use(async (context, next) => {


    await context.Response.WriteAsync("Welcome by Use Middleware2\n");
    await next(context);

});

app.Run(async (context) => {


    await context.Response.WriteAsync("Welcome by Run Middleware\n");

});

app.Run();
