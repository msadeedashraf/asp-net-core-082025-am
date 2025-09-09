using Platform;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.UseMiddleware<Population>();
//app.UseMiddleware<Capital>();

//app.UseRouting();

app.MapGet("{first}/{second}/{third}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (var kvp in context.Request.RouteValues)
    {
        await context.Response
        .WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});
app.MapGet("capital/uk", new Capital().Invoke);
app.MapGet("population/paris", new Population().Invoke);


//app.Run(async (context) => {
//    await context.Response.WriteAsync("Terminal Middleware Reached");
//});

app.Run();
