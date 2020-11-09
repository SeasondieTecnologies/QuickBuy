using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetodeValor;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class FormaDePagamentoConfiguration : IEntityTypeConfiguration<FormaDePagamento>
    {
        public void Configure(EntityTypeBuilder<FormaDePagamento> builder)
        {
            builder.Property(f => f.Id);

            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
