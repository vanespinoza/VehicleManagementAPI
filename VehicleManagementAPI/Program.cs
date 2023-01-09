using Microsoft.EntityFrameworkCore;
using VehicleManagementAPI.DataAccess;
using VehicleManagementAPI.Repositories.Implementations;
using VehicleManagementAPI.Repositories.Interfaces;
using VehicleManagementAPI.Services.Profiles;
using VehicleManagementAPI.Services.Interfaces;
using VehicleManagementAPI.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<VehicleManagementDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("VehicleManagementDb"));

    options.EnableSensitiveDataLogging();
});

builder.Services.AddAutoMapper(c =>
{
    c.AddProfile<AssignmentProfile>();
    c.AddProfile<BrandProfile>();
    c.AddProfile<DriverProfile>();
    c.AddProfile<VehicleProfile>();
});

builder.Services.AddTransient<IAssignmentRepository, AssignmentRepository>();
builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<IDriverRepository, DriverRepository>();
builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();

builder.Services.AddTransient<IAssignmentService, AssignmentService>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<IDriverService, DriverService>();
builder.Services.AddTransient<IVehicleService, VehicleService>();


builder.Services.AddControllers();

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
