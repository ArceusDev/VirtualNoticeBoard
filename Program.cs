
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace VirtualNoticeBoard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<VirtualNoticeBoardDBContext>
                (
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("VirtualNoticeBoardDB"))
                );

            foreach (var service in builder.Services)
            {
                Console.WriteLine($"{service.ServiceType}");
            }
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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}