
using HarmanProductsCatelogService.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace HarmanProductsCatelogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddDbContext<ProductsCatalogDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
            }
            );

            builder.Services.AddScoped<IProductsCatalogRepository, ProductsCatalogRepository>();
            //builder.Services.AddTransient<IProductsCatalogRepository, ProductsCatalogRepository>();
            //builder.Services.AddSingleton<IProductsCatalogRepository, ProductsCatalogRepository>();

            builder.Services.AddControllers();
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
