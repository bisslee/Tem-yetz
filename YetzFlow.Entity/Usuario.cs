using System;
using System.Collections.Generic;
using System.Text;

namespace YetzFlow.Entity
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public DateTime? UltimoLogin { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }

}
