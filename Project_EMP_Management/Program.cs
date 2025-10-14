using Microsoft.EntityFrameworkCore;
using Project_EMP_Management.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(option=>
option.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
var app = builder.Build();

using ( var scope = app.Services.CreateScope())
{
var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
var dataSeedHelper = new DataSeedHelper(dbContext);
    dataSeedHelper.InsertData();
}
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
