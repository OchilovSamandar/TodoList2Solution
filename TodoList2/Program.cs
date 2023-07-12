using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoList2.Data;
using TodoList2.Data.TodoRepo;
using TodoList2.Data.UserRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//database connection
var defaultconnection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException();
builder.Services.AddDbContext<TodoContext>(options => options.UseSqlServer(defaultconnection));

builder.Services.AddScoped<ITodoRepository,SqlTodoRepository>();
builder.Services.AddScoped<IUserRepository,SqlUserRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
