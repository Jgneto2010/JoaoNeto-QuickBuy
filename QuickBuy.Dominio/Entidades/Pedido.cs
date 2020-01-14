using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidades
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Enderecocompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public ICollection<ItemPedido> ItemPedidos { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            
            if (!ItemPedido.Any())
            AdicionarCritica("Pedido está vazio");

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("CEP deve ser preenchido");
            if (FormaPagamentoId == 0)
                AdicionarCritica("Informe a forma de pagamento");

        }
    }
}
