using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Importando os namespaces necess�rios

namespace Api.Data.Test
{
    // Namespace onde a classe est� contida

    public abstract class BaseTest
    {
        // Classe abstrata para servir de base para os testes
    }

    public class DbTest : IDisposable
    {
        // Classe que realiza testes de banco de dados e implementa IDisposable

        private string dataBaseName = $"dbApiTest{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        // Gera um nome �nico para o banco de dados usando um GUID

        public ServiceProvider ServiceProvider { get; set; }
        // Propriedade para acessar o provedor de servi�os

        public DbTest()
        {
            // Construtor da classe DbTest

            var serviceCollection = new ServiceCollection();
            // Cria uma cole��o de servi�os para configurar a inje��o de depend�ncia

            serviceCollection.AddDbContext<MyContext>(options => options
                .UseMySql($"server=localhost;port=3306;database={dataBaseName};user=root;password=admin", ServerVersion.AutoDetect($"server=localhost;port=3306;database={dataBaseName};user=root;password=admin")),
                ServiceLifetime.Transient);
            // Adiciona o contexto do banco de dados MyContext aos servi�os e configura-o para usar MySQL
            // O nome do banco de dados � gerado dinamicamente para evitar conflitos durante os testes
            // Configura o tempo de vida do servi�o como Transient, o que significa que uma nova inst�ncia do contexto do banco de dados ser� criada a cada solicita��o dos servi�os que dependem dele.

            ServiceProvider = serviceCollection.BuildServiceProvider();
            // Constr�i o provedor de servi�os a partir da cole��o de servi�os configurada

            using (var context = ServiceProvider.GetService<MyContext>())
            { // Obt�m uma inst�ncia do contexto do banco de dados MyContext do provedor de servi�os (ServiceProvider).
               
                context.Database.EnsureCreated();
                // Verifica se o banco de dados definido no contexto (MyContext) existe. Se o banco de dados n�o existir, ele ser� criado
            }
            // Usa o provedor de servi�os para obter uma inst�ncia do contexto do banco de dados e garante que o banco de dados seja criado antes dos testes
        }

        public void Dispose()
        {
            // M�todo Dispose que � chamado quando a inst�ncia de DbTest � liberada

            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted();
            }
            // Usa o provedor de servi�os para obter uma inst�ncia do contexto do banco de dados e garante que o banco de dados seja exclu�do ap�s os testes
        }
    }
}
