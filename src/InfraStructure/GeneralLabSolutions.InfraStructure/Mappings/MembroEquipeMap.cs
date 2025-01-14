using GeneralLabSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeneralLabSolutions.InfraStructure.Mappings
{
    public class MembroEquipeMap : IEntityTypeConfiguration<MembroEquipe>
    {
        public void Configure(EntityTypeBuilder<MembroEquipe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Nome)
                .HasDatabaseName("IX_MembroEquipe_Nome"); // Adicionado índice para o nome

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            // Relation - MembroEquipe N:N GerenciadorDeFluxoKanban - já mapeada na entidade GerenciadorDeFluxoKanban 
        }
    }
}