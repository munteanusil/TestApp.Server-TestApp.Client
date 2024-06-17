using MySqlConnector;
using System.Data;
using TestApp.Application;
using TestApp.DataAccess;
using TestApp.DataAccess.Repositories;
using TestApp.Domain;

namespace TestApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<ITodoService, TodoService>();
            builder.Services.AddScoped<INoteRepository, NoteRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IDataAccess, SqlDataAccess>();
            builder.Services.AddScoped<IDbConnection, MySqlConnection>();
            builder.Services.AddScoped<INoteDomainService, NoteDomainService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();
            

            app.MapControllers();

            app.Run();
        }
    }
}
