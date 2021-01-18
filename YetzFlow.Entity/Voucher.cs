using System;
using System.Collections.Generic;
using System.Text;

namespace YetzFlow.Entity
{
    public class Voucher
    {
        public int IdVoucher { get; set; }
        public string Nome { get; set; }
        public int IdTipo { get; set; }
        public int IdOrigem { get; set; }
        public int? CodigoPlataforma { get; set; }
        public double Valor { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int? IdUsuarioCriacao { get; set; }
        public int? IdUsuarioAtualizacao { get; set; }
    }
}
