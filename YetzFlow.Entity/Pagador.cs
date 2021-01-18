using System;
using System.Collections.Generic;
using System.Text;

namespace YetzFlow.Entity
{
    public class Pagador
    {
        public int IdPagador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }
}
