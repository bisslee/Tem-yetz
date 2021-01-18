﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Site.Caller;

namespace YetzFlow.Site
{
    public partial class CompraPontos : System.Web.UI.Page
    {
        public int TotalRegistros { get; set; }
        public string NomePagina { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NomePagina = "Compra Pontos";
            //Master.NomePagina = NomePagina;

            if (!IsPostBack)
            {
                MontaLista();
            }
        }
        private void MontaLista()
        {
            var lista = new ProxyCompraPontos().GetAll();
            TotalRegistros = lista != null ? lista.Count() : 0;
            rptEntity.DataSource = lista;
            rptEntity.DataBind();
        }
    }
}