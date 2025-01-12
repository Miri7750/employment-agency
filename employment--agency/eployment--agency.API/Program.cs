using eployment__agency.Core.Entities;
using eployment__agency.Core.IRepositories;
using eployment__agency.Core.IServices;
using eployment__agency.Service.Services;
using eployment__agency.Data;
using eployment__agency.Data.Repositories;
using Microsoft.Extensions.Logging;

namespace eployment__agency.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IBrokerageService, BrokerageService>();
            builder.Services.AddScoped<IBusinessService, BusinessService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IJubService, JubService>();
            builder.Services.AddScoped<IRegionService, RegionService>();
            builder.Services.AddScoped<IRepository<Brokerage>, BrokerageRepository>();
            builder.Services.AddScoped<IRepository<Business>, BusinessRepository>();

            builder.Services.AddScoped<IRepository<Employee>, EmployeeRepository>();
            builder.Services.AddScoped<IRepository<Jub>, JubRepository>();
            builder.Services.AddScoped<IRepository<Region>, RegionRepository>();
            //builder.Services.AddDbContext<DataContext>(option => 
             //   option.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db"));
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