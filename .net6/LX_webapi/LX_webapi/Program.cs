

using LX_webapi.Models;
using LX_webapi.Services;
using LX_webapi.Services.IServices;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddCors(c => c.AddPolicy("any", p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IUserService,UserService>();
builder.Services.AddTransient<UserService>();

builder.Services.AddTransient<IScopedService,ScopedService>();
builder.Services.AddTransient<ISingletonService,SingletonService>();
builder.Services.AddTransient<ITransientService,TransientService>();
builder.Services.AddTransient<IIocService1,IocService1>();
builder.Services.AddTransient<IIocService2,IocService2>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

//app.UseCors();

//要想访问项目的静态文件就得配置静态文件中间件
app.UseStaticFiles(new StaticFileOptions()
{

    FileProvider = new PhysicalFileProvider(

Path.Combine(Directory.GetCurrentDirectory(), @"Views")),

    RequestPath = new PathString("/Views")

});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapGet("/", HelloWorld.Hello);

string Hi() => "HI";
//app.MapGet("/", Hi);

app.MapGet("/", (UserService userservice)=> {
    return userservice.GetUserName();
});

app.MapPost("/",(TestPostViewModel model) => 
{ 
    return model; 
});

app.Run();

public class HelloWorld
{
    public static string Hello()
    {
        return "helloword";
    }
}

