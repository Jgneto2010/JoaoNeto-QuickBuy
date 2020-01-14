using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidades
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi informado a referencia do produto");

            if (Quantidade == 0)
                AdicionarCritica("Informe a Quantidade");
        }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
