using System;
using System.Collections.Generic;
using System.Text;

namespace YetzFlow.Entity
{
    public class CompraPonto
    {
        public int IdCompraPonto { get; set; }
        public int IdCampanha { get; set; }
        public int IdTipoCredito { get; set; }
        public int IdObservacao { get; set; }
        public int Unidades { get; set; }
        public long Pontos { get; set; }
        public double TotalPontos { get; set; }
        public double ValorYetz { get; set; }
        public double ValorPontos { get; set; }
        public double ValorTotal { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }
}
