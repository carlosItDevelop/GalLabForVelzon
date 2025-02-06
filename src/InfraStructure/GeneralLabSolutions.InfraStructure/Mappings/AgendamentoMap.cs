using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeneralLabSolutions.InfraStructure.Mappings
{
    public class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasIndex(x => x.Descricao).HasDatabaseName("IX_Agendamento_Descricao");
            builder.HasIndex(x => x.Titulo).IsUnique().HasDatabaseName("IX_Agendamento_Titulo");
            builder.HasIndex(x => x.Localizacao).HasDatabaseName("IX_Agendamento_Localizacao");

            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasComment("Título do Compromisso")
                .HasColumnType("varchar(80)");

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasComment("Descrição do Compromisso")
                .HasColumnType("varchar(600)");

            builder.Property(x => x.Localizacao)
                .HasColumnType("varchar(150)");

            builder.Property(x => x.DataInicio)
                .IsRequired()
                .HasColumnName("DataInicio")
                .HasColumnType("datetime");

            builder.Property(x => x.DataFim)
                .HasColumnName("DataFim")
                .HasColumnType("datetime");


            builder.Property(a => a.TipoEvento)
                .HasEnumConversion()
                .HasDefaultValue(TipoEvento.Info)
                .IsRequired();

            // Outras configurações...
        }
    }
}
