using RailwayAPI.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

string conn = "Data Source=DESKTOP-H788HM6\\MCMSQL;Initial Catalog=railway;User ID=sa;Password=sql;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=Yes;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False;Integrated Security=False";



builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<TrainRepository>();
builder.Services.AddScoped<BookingRepository>();
builder.Services.AddScoped<ClassRepository>();
builder.Services.AddScoped<ScheduleRepository>();
builder.Services.AddScoped<SeatRepository>();
builder.Services.AddDbContext<AppDBContext>(optoions => optoions.UseSqlServer(conn));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
