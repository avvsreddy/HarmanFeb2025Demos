
using HarmanProductsCatelogService.DataLayer;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HarmanProductsCatelogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson();
            builder.Services.AddOData();


            builder.Services.AddDbContext<ProductsCatalogDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
            }
            );

            builder.Services.AddAuthorization();

            builder.Services.AddIdentityApiEndpoints<IdentityUser>()
           .AddEntityFrameworkStores<ProductsCatalogDbContext>();

            builder.Services.AddScoped<IProductsCatalogRepository, ProductsCatalogRepository>();
            //builder.Services.AddTransient<IProductsCatalogRepository, ProductsCatalogRepository>();
            //builder.Services.AddSingleton<IProductsCatalogRepository, ProductsCatalogRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            var app = builder.Build();
            app.MapIdentityApi<IdentityUser>();
            builder.Services.AddEndpointsApiExplorer();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();


            app.UseAuthentication();




            //app.MapControllers();

            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(ep =>
            {
                ep.EnableDependencyInjection();
                ep.Select().Filter().Count().OrderBy().MaxTop(100).SkipToken();
                ep.MapControllers();
            });


            app.Run();
        }
    }
}
