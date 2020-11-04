using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetodeValor
{
    class FormaDePagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool EhCartaoDeCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDeCredito; }
        }
        public bool EhDepositoBancario
        {
            get { return Id == (int)TipoFormaPagamentoEnum.DepositoBancario; }
        }
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
