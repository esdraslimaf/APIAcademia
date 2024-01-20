using Api.Data.Context;
using Api.Data.Implementation;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;
using Api.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfiguracaoDependenciaRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddTransient<IUserRepository, UserImplementation>();
            serviceCollection.AddDbContext<MyContext>(options => options.UseMySql("server=localhost;port=3306;database=teste1;user=root;password=admin", ServerVersion.AutoDetect("server=localhost;port=3306;database=teste1;user=root;password=admin")));
        }
    }
}
