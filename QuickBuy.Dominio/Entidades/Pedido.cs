using QuickBuy.Dominio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
   public  class Pedido:Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

       public int FormaDePagamentoId { get; set; }

        public FormaDePagamento FormaDePagamento { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido.");

            if (FormaDePagamentoId == 0)
                AdicionarCritica("Não foi informado a forma de pagamento");
        }
    }
}
