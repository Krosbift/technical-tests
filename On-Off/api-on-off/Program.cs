using api_on_off.src.routes.raffleNumbers.context;
using api_on_off.src.routes.raffleNumbers.repository;
using api_on_off.src.routes.raffleNumbers.service;
using Microsoft.EntityFrameworkCore;

namespace api_on_off
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<RaffleNumbersContext>(
                ctx => ctx.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<RaffleNumberService>();
            builder.Services.AddScoped<RaffleNumberRepository>();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();
            app.Run("http://localhost:3000");
        }
    }
}