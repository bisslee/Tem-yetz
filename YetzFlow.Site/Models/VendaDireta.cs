using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YetzFlow.Site.Models
{
    public class VendaDireta
    {
        public int IdVendaDireta { get; set; }
        public int IdCampanha { get; set; }
        public int IdPagador { get; set; }
        public int? NumeroNota { get; set; }
        public Double Valor { get; set; }
        public DateTime? DataEmissao { get; set; }
        public int? IdStatus { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }
}