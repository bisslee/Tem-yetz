using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YetzFlow.Site.Models
{
    public class Campanha
    {
        public int IdCampanha { get; set; }
        public string Nome { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataTermino { get; set; }
        public double FatorConversao { get; set; }
        public double Taxa { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }
}