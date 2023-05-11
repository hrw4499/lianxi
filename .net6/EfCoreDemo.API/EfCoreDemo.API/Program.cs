using EfCoreDemo.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Net.NetworkInformation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(c=>c.AddPolicy("any",p=>p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
var configuration = builder.Configuration;
//builder.Services.AddScoped<IKUNContext>();
builder.Services.AddDbContext<IKUNContext>(
    option => {
        option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        option.UseSqlServer(configuration.GetConnectionString("Default"));
    }
);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles(new StaticFileOptions()
{ 
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Views")),RequestPath = new PathString("/Views")
    
});

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
