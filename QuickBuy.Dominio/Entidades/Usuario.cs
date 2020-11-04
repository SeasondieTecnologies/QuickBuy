using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //O usisario pode ter nenhum ou vairios pedidos.
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
