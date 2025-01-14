using GeneralLabSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeneralLabSolutions.InfraStructure.Mappings
{
    public class GerenciadorDeFluxoKanbanMap : IEntityTypeConfiguration<GerenciadorDeFluxoKanban>
    {
        public void Configure(EntityTypeBuilder<GerenciadorDeFluxoKanban> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Titulo)
                .HasDatabaseName("IX_GerenciadorDeFluxoKanban_Titulo"); // Adicionado índice para o título

            builder.HasIndex(x => x.Status)
                .HasDatabaseName("IX_GerenciadorDeFluxoKanban_Status"); // Adicionado índice para o status

            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(1000);


            builder.Property(x => x.Status)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.DataVencimento)
                .IsRequired()
                .HasColumnType("date");

            // Relation - GerenciadorDeFluxoKanban N:N MembroEquipe
            builder.HasMany(x => x.Membros)
                .WithMany(x => x.Tarefas)
                .UsingEntity(j => j.ToTable("TarefaMembro"));


        }
    }
}