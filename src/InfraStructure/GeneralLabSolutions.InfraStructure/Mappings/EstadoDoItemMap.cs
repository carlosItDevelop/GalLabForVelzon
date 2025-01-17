using GeneralLabSolutions.Domain.Entities;
using GeneralLabSolutions.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeneralLabSolutions.InfraStructure.Mappings
{
    public class EstadoDoItemMap : IEntityTypeConfiguration<EstadoDoItem>
    {
        public void Configure(EntityTypeBuilder<EstadoDoItem> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Status)
                .HasEnumConversion()
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(e => e.DataAlteracao)
                .IsRequired()
                .HasColumnType("datetime2");

            // Relacionamento com ItemPedido
            builder.HasOne(e => e.ItemPedido)
                .WithOne(i => i.EstadoDoItem)
                .HasForeignKey<EstadoDoItem>(e => e.ItemPedidoId)
                .OnDelete(DeleteBehavior.NoAction); // Define conforme a lógica de negócio

            builder.ToTable("EstadoDoItem");
        }
    }
}
