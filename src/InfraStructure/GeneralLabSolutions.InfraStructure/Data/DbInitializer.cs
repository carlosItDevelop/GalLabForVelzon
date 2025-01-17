using GeneralLabSolutions.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GeneralLabSolutions.InfraStructure.Data;
public static class DbInitializer
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var scopedProvider = scope.ServiceProvider;
            var context = scopedProvider.GetRequiredService<AppDbContext>();

            // Usar uma única transação para todos os SeedData
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Chamar os SeedData na ordem correta
                    SeedDataCategoriaProduto.Initialize(scopedProvider);
                    SeedDataFornecedor.Initialize(scopedProvider);
                    SeedDataCliente.Initialize(scopedProvider);
                    SeedDataVendedor.Initialize(scopedProvider);
                    SeedDataProduto.Initialize(scopedProvider);
                    SeedDataPedido.Initialize(scopedProvider);
                    SeedDataContato.Initialize(scopedProvider);
                    SeedDataTelefone.Initialize(scopedProvider);
                    SeedDataGerenciadorDeFluxoKanban.Initialize(scopedProvider);

                    // Se chegou até aqui sem erros, commita a transação
                    await context.SaveChangesAsync(); //Salvar todas as alterações na mesma transação.
                    await transaction.CommitAsync();

                    Console.WriteLine("SeedData para Categoria de Produto gerado com sucesso!");
                    Console.WriteLine("SeedData para Cliente gerado com sucesso!");
                    Console.WriteLine("SeedData para Contato e PessoaContato gerados com sucesso!");
                    Console.WriteLine("SeedData para Fornecedor gerado com sucesso!");
                    Console.WriteLine("SeedData para GerenciadorDeFluxoKanban gerado com sucesso!");
                    Console.WriteLine("SeedData para MembrosEquipe gerado com sucesso!");
                    Console.WriteLine("SeedData para Pedido, ItemPedido e EstadoDoItem gerado com sucesso!");
                    Console.WriteLine("SeedData para Produto gerado com sucesso!");
                    Console.WriteLine("SeedData para Telefone e PessoaTelefone gerados com sucesso!");
                    Console.WriteLine("SeedData para Vendedor gerado com sucesso!");




                    Console.WriteLine("\n\n================================\nSeedData executado com sucesso!");
                } catch (Exception ex)
                {
                    // Em caso de erro, faz rollback da transação
                    await transaction.RollbackAsync();
                    Console.WriteLine($"Erro durante a execução do SeedData: {ex.Message}");
                    // Aqui você pode logar o erro, lançar a exceção novamente, etc.
                    throw;
                }
            }
        }
    }
}