using Api.Application.Security;
using Api.CrossCutting.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace Api.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureService.ConfiguracaoDependenciaService(builder.Services);
            ConfigureRepository.ConfiguracaoDependenciaRepository(builder.Services);

            var signingConfigurations = new SigningConfigurations();
            builder.Services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                builder.Configuration.GetSection("TokenConfigurations")).Configure(tokenConfigurations);

            builder.Services.AddSingleton(tokenConfigurations);




            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V1", new OpenApiInfo { Title = "Academia API - V1", Version = "v1" });
            });


            var app = builder.Build();
           
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/V1/swagger.json", "Academia V1");
                    c.RoutePrefix = "swagger";
                });

            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}