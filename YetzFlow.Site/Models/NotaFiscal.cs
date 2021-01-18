using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YetzFlow.Site.Models
{
    public class NotaFiscal
    {
        public int IdNotasFiscal { get; set; }
        public int? Numero { get; set; }
        public double? Valor { get; set; }
        public DateTime? DataEmissao { get; set; }
        public int IdStatus { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }
}