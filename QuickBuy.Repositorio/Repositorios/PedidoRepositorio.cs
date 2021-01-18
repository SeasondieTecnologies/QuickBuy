using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Repositorio.Context;
using System.Collections.Generic;

namespace QuickBuy.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<ItemPedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {

        }

        public void Adicionar(Pedido entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Pedido entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(Pedido entity)
        {
            throw new System.NotImplementedException();
        }

        Pedido IBaseRepositorio<Pedido>.ObterPorId(int Id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Pedido> IBaseRepositorio<Pedido>.ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
