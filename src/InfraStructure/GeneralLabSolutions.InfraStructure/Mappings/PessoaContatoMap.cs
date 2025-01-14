using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralLabSolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GeneralLabSolutions.InfraStructure.Mappings
{
    public class PessoaContatoMap : IEntityTypeConfiguration<PessoaContato>
    {
        public void Configure(EntityTypeBuilder<PessoaContato> builder)
        {
            builder.HasKey(pt => new { pt.PessoaId, pt.ContatoId }); // Chave composta

            builder.HasOne(pt => pt.Pessoa)
                   .WithMany(p => p.PessoasContatos)
                   .HasForeignKey(pt => pt.PessoaId);

            builder.HasOne(pt => pt.Contato)
                   .WithMany(t => t.PessoasContatos)
                   .HasForeignKey(pt => pt.ContatoId);
        }
    }
}
