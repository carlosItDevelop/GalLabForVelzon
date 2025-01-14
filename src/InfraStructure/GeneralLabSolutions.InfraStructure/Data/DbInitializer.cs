using GeneralLabSolutions.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GeneralLabSolutions.InfraStructure.Data;
public static class DbInitializer
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            // ... (verificação de ambiente - opcional) ...

            SeedDataCategoriaProduto.Initialize(serviceProvider);
            SeedDataFornecedor.Initialize(serviceProvider);
            SeedDataCliente.Initialize(serviceProvider);
            SeedDataVendedor.Initialize(serviceProvider);
            SeedDataProduto.Initialize(serviceProvider);
            SeedDataPedido.Initialize(serviceProvider);
            SeedDataContato.Initialize(serviceProvider);
            SeedDataTelefone.Initialize(serviceProvider);
            SeedDataGerenciadorDeFluxoKanban.Initialize(serviceProvider); // Posicionar corretamente quando tivermos os detalhes da entidade

            //context.SaveChanges(); // Já tem nos SeedDatas
        }
    }

    // ... (outros métodos auxiliares do SeedData, se houver) ...
}