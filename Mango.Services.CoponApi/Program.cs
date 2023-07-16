
using Mango.Services.CoponApi.Configuration;
using Mango.Services.CoponApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CoponApi
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

            //connect to DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            //add auto mapper
            builder.Services.AddAutoMapper(typeof(MappingConfig));

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
            ApplyMigration();

            app.Run();


            void ApplyMigration()
            {
                using(var scope = app.Services.CreateScope())
                {
                    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    if(db.Database.GetPendingMigrations().Count() > 0)
                    {
                        db.Database.Migrate();
                    }
                    
                }
            }
        }
    }
}