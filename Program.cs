using Microsoft.EntityFrameworkCore;
using BookingSystem_Hairdresser.Data; 

namespace BookingSystem_Hairdresser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // L�gg till databaskontext
            builder.Services.AddDbContext<BookingDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookingDB;Trusted_Connection=True;"));

            // L�gg till �vriga tj�nster
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
