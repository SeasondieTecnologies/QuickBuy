using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetodeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<FormaDePagamento> FormaDePagamento { get; set; }
        public QuickBuyContexto( DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaDePagamentoConfiguration());

            modelBuilder.Entity<FormaDePagamento>().HasData
                (new FormaDePagamento()
                { 
                    Id = 1,
                    Nome="Boleto", 
                    Descricao= "Forma de pagamento em boleto" 
                });

            modelBuilder.Entity<FormaDePagamento>().HasData
                (new FormaDePagamento()
                {
                    Id = 2,
                    Nome = "Cartão de crédito",
                    Descricao = "Forma de Pagamento no cartão de crédito"
                });
            modelBuilder.Entity<FormaDePagamento>().HasData
               (new FormaDePagamento()
               {
                   Id = 3,
                   Nome = "Depósito bancário",
                   Descricao = "Forma de pagamento com depósito bancário"
               });
            base.OnModelCreating(modelBuilder);
        }
    }
}
