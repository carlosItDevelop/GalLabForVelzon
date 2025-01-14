using GeneralLabSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GeneralLabSolutions.InfraStructure.Data
{
    public static class SeedDataGerenciadorDeFluxoKanban
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                // Verificar se o contexto e a tabela existem
                if (context == null || context.GerenciadorDeFluxoKanban == null)
                {
                    throw new ArgumentNullException("Null AppDbContext");
                }

                if (!context.GerenciadorDeFluxoKanban.Any())
                {
                    var random = new Random();

                    // --- 1. Definir os Status do Kanban ---
                    var statusKanban = new List<string>
                    {
                        "Unassigned", "ToDo", "Inprogress", "InReviews", "Completed", "New" // <<<==== Nomes atualizados
                    };

                    // --- 2. Criar Dados para MembroEquipe ---
                    var membros = CriarMembrosEquipe(context, random);

                    // --- 3. Gerar Tarefas ---
                    var tarefas = GerarTarefas(random, statusKanban, membros);

                    // --- 5. Inserir Tarefas no Banco de Dados ---
                    context.GerenciadorDeFluxoKanban.AddRange(tarefas);
                    context.SaveChanges();
                } else
                {
                    Console.WriteLine("O SeedData para GerenciadorDeFluxoKanban já foi gerado!");
                }
            }
        }

        // --- 2. (Método auxiliar) Criar Dados para MembroEquipe ---
        private static List<MembroEquipe> CriarMembrosEquipe(AppDbContext context, Random random)
        {
            var membros = new List<MembroEquipe>
            {
                new MembroEquipe { Nome = "Ana Silva" },
                new MembroEquipe { Nome = "Bruno Santos" },
                new MembroEquipe { Nome = "Carla Oliveira" },
                new MembroEquipe { Nome = "Daniel Pereira" }
                // Adicione mais membros aqui, se necessário
            };

            // Inserir os membros no banco de dados
            context.MembroEquipe.AddRange(membros);
            context.SaveChanges();

            return membros;
        }

        // --- 3. (Método auxiliar) Gerar Tarefas ---
        private static List<GerenciadorDeFluxoKanban> GerarTarefas(Random random, List<string> statusKanban, List<MembroEquipe> membros)
        {
            var tarefas = new List<GerenciadorDeFluxoKanban>();

            foreach (var status in statusKanban)
            {
                // Gere um número aleatório de tarefas para cada status
                int numTarefas = random.Next(3, 8); // Entre 3 e 7 tarefas

                for (int i = 0; i < numTarefas; i++)
                {
                    var tarefa = new GerenciadorDeFluxoKanban(
                        GerarTituloTarefa(random, status),
                        GerarDescricaoTarefa(random),
                        status, // Defina o status
                        GerarDataVencimento(random)
                    );

                    // Associe membros aleatoriamente à tarefa
                    int numMembros = random.Next(1, 4); // Entre 1 e 3 membros por tarefa
                    for (int j = 0; j < numMembros; j++)
                    {
                        tarefa.Membros.Add(membros [random.Next(membros.Count)]);
                    }

                    tarefas.Add(tarefa);
                }
            }

            return tarefas;
        }

        // --- Métodos auxiliares para gerar dados da tarefa ---
        private static string GerarTituloTarefa(Random random, string status)
        {
            var titulos = new List<string> {
                "Implementar nova funcionalidade",
                "Criar testes unitários",
                "Refatorar código",
                "Criar documentação",
                "Analisar requisitos",
                "Projetar interface",
                "Corrigir bugs"
            };

            var verbos = new List<string> {
                "Revisar", "Finalizar", "Testar", "Implementar", "Criar", "Analisar", "Corrigir"
            };

            if (status == "Completed")
            {
                return $"{verbos [random.Next(verbos.Count)]} {titulos [random.Next(titulos.Count)]}";
            } else
            {
                return $"{titulos [random.Next(titulos.Count)]}";
            }
        }

        private static string GerarDescricaoTarefa(Random random)
        {
            var descricoes = new List<string> {
                "Esta tarefa envolve a implementação de uma nova funcionalidade para o sistema.",
                "É necessário criar testes unitários para garantir a qualidade do código.",
                "O código precisa ser refatorado para melhorar a legibilidade e a manutenibilidade.",
                "Criar documentação completa e atualizada para o projeto.",
                "Realizar uma análise detalhada dos requisitos do sistema.",
                "Projetar a interface do usuário de forma intuitiva e amigável.",
                "Corrigir os bugs relatados pelos usuários."
            };
            return descricoes [random.Next(descricoes.Count)];
        }

        private static DateTime GerarDataVencimento(Random random)
        {
            // Gerar datas entre hoje e 30 dias no futuro
            return DateTime.Now.AddDays(random.Next(1, 31));
        }

        // ... (outros métodos auxiliares)
    }
}