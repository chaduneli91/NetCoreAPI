using BannersAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer("Server=DESKTOP-25PSFRS; Database=BannersDB; Trusted_Connection=True; TrustServerCertificate=True");
        });

        builder.Services.AddCors(options => options.AddPolicy(name: "BannersOrigin",

            policy =>
                {
                    policy.WithOrigins("http://localhost4200").AllowAnyMethod().AllowAnyHeader();
                }

            ));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors("BannersOrigin");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}