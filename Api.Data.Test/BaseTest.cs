using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Importando os namespaces necessários

namespace Api.Data.Test
{
    // Namespace onde a classe está contida

    public abstract class BaseTest
    {
        // Classe abstrata para servir de base para os testes
    }

    public class DbTest : IDisposable
    {
        // Classe que realiza testes de banco de dados e implementa IDisposable

        private string dataBaseName = $"dbApiTest{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        // Gera um nome único para o banco de dados usando um GUID

        public ServiceProvider ServiceProvider { get; set; }
        // Propriedade para acessar o provedor de serviços

        public DbTest()
        {
            // Construtor da classe DbTest

            var serviceCollection = new ServiceCollection();
            // Cria uma coleção de serviços para configurar a injeção de dependência

            serviceCollection.AddDbContext<MyContext>(options => options
                .UseMySql($"server=localhost;port=3306;database={dataBaseName};user=root;password=admin", ServerVersion.AutoDetect($"server=localhost;port=3306;database={dataBaseName};user=root;password=admin")),
                ServiceLifetime.Transient);
            // Adiciona o contexto do banco de dados MyContext aos serviços e configura-o para usar MySQL
            // O nome do banco de dados é gerado dinamicamente para evitar conflitos durante os testes
            // Configura o tempo de vida do serviço como Transient, o que significa que uma nova instância do contexto do banco de dados será criada a cada solicitação dos serviços que dependem dele.

            ServiceProvider = serviceCollection.BuildServiceProvider();
            // Constrói o provedor de serviços a partir da coleção de serviços configurada

            using (var context = ServiceProvider.GetService<MyContext>())
            { // Obtém uma instância do contexto do banco de dados MyContext do provedor de serviços (ServiceProvider).
               
                context.Database.EnsureCreated();
                // Verifica se o banco de dados definido no contexto (MyContext) existe. Se o banco de dados não existir, ele será criado
            }
            // Usa o provedor de serviços para obter uma instância do contexto do banco de dados e garante que o banco de dados seja criado antes dos testes
        }

        public void Dispose()
        {
            // Método Dispose que é chamado quando a instância de DbTest é liberada

            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted();
            }
            // Usa o provedor de serviços para obter uma instância do contexto do banco de dados e garante que o banco de dados seja excluído após os testes
        }
    }
}
