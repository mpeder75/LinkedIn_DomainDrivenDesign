using Microsoft.EntityFrameworkCore;
using Wpm.Managment.Api;
using Wpm.Managment.Api.Infrastructure;
using Wpm.Managment.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IManagmentService, ManagmentService>();
builder.Services.AddScoped<IBreedService, BreedService>();
builder.Services.AddScoped<IManagmentRepository, ManagmentRepository>();
builder.Services.AddDbContext<ManagementDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.EnsureDbIsCreated();

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