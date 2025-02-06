using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GeneralLabSolutions.InfraStructure.Data
{
    public static class SeedDataAgendamento
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context == null || context.Agendamento == null)
                {
                    throw new ArgumentNullException("Null AppDbContext");
                }

                if (!context.Agendamento.Any())
                {
                    var random = new Random();
                    var tiposEvento = Enum.GetValues(typeof(TipoEvento)).Cast<TipoEvento>().ToList();

                    for (int month = 1; month <= 12; month++)
                    {
                        for (int i = 0; i < 5; i++) // Criar pelo menos 5 compromissos por mês
                        {
                            try
                            {
                                var startDate = new DateTime(2025, month, random.Next(1, DateTime.DaysInMonth(2025, month) + 1), random.Next(8, 18), random.Next(0, 60), 0);
                                var endDate = startDate.AddHours(random.Next(1, 4)); // Duração aleatória de 1 a 3 horas
                                var tipoEvento = tiposEvento [random.Next(tiposEvento.Count)];

                                var agendamento = new Agendamento(
                                    titulo: $"Compromisso {i + 1} - {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)}",
                                    descricao: $"Descrição de exemplo para o compromisso {i + 1} em {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month)}.",
                                    dataInicio: startDate
                                )
                                {
                                    DataFim = endDate,
                                    Localizacao = $"Local Exemplo {random.Next(1, 10)}",
                                    TipoEvento = tipoEvento,
                                    DiaTodo = random.Next(0, 2) == 1 // 50% de chance de ser dia todo
                                };

                                context.Agendamento.Add(agendamento);
                            } catch (Exception ex)
                            {
                                Console.WriteLine($"Erro ao criar Agendamento de SeedData: {ex.Message}");
                                // Em ambiente real, logar a exceção adequadamente
                            }
                        }
                    }

                    context.SaveChanges();
                    Console.WriteLine("SeedData para Agendamento gerado com sucesso!");
                } else
                {
                    Console.WriteLine("SeedData para Agendamento já foi gerado!");
                }
            }
        }
    }
}
