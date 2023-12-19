using Empoyee_Management_System.Database;
using Empoyee_Management_System.Interfaces;
using Empoyee_Management_System.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IPayrollService, PayrollService>();

     builder.Services.AddDbContext<Employee_DbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs"),
            sqlServerOptions => sqlServerOptions.CommandTimeout(600)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
