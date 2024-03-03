using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        //Abaixo é usado para criar as migrações em tempo de criação do projeto
        public MyContext CreateDbContext(string[] args)
        {
            var stringConnection = "server=localhost;port=3306;database=teste2;user=root;password=admin";
            //Abaixo é uma maneira de configurar opções para o DbContext chamado MyContext
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();         
            /* Ele cria uma instância de DbContextOptionsBuilder que pode ser usada para configurar opções para o DbContext123. Essas opções podem incluir coisas como a string de conexão do banco de dados, o provedor de banco de dados (por exemplo, SQL Server, SQLite, etc.), configurações de pool de conexões e muito mais */
            
            optionsBuilder.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection));

            //Abaixo estamos retornando o contexto de conexão com o banco de dados, possibilitando a criação das migrações
            return new MyContext(optionsBuilder.Options);

        }
    }
}
