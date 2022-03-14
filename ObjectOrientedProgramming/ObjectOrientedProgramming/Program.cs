using Microsoft.EntityFrameworkCore;
using ObjectOrientedProgramming.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<CustomerContext>(opt =>opt.UseInMemoryDatabase("CustomerList"));
builder.Services.AddDbContext<AddressContext>(opt => opt.UseInMemoryDatabase("AddressList"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseDeveloperExceptionPage();  
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
