using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidades
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string  NomeUsuario { get; set; }
        public string SobreNome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não Informado");
            
            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não Informada");

        }
    }
}
