var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddCarter();

var app = builder.Build();

// Configure the HTTP request pipline.
app.MapCarter();

app.Run();
