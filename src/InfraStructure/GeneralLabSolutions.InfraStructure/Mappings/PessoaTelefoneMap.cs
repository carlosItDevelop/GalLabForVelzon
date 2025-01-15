using GeneralLabSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeneralLabSolutions.InfraStructure.Mappings
{
    public class PessoaTelefoneMap : IEntityTypeConfiguration<PessoaTelefone>
    {
        public void Configure(EntityTypeBuilder<PessoaTelefone> builder)
        {
            builder.HasKey(pt => new { pt.PessoaId, pt.TelefoneId }); // Chave composta

            builder.HasOne(pt => pt.Pessoa)
                   .WithMany(p => p.PessoasTelefones)
                   .HasForeignKey(pt => pt.PessoaId);

            builder.HasOne(pt => pt.Telefone)
                   .WithMany(t => t.PessoasTelefones)
                   .HasForeignKey(pt => pt.TelefoneId);
        }
    }
}
