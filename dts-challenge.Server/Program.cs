
using dts_challenge.Server.Data;
using dts_challenge.Server.Repositories.Implementations;
using dts_challenge.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace dts_challenge.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer( builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<ITaskRepository, TaskRepository>();

            var app = builder.Build();

            app.UseDefaultFiles();
            //app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
