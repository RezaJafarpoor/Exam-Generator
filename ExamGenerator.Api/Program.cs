using ExamGenerator.Infrastructure.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddInfrastructure(builder.Configuration);
    

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();


app.Run();


