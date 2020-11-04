﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
   public class ItemPedido
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
