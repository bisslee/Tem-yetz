using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YetzFlow.Site
{
    public partial class Home : System.Web.UI.Page
    {
        public string NomePagina { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NomePagina = "Indicadores";
            Session["NomePagina"] = NomePagina;

            if (!IsPostBack)
            {
                MontaLista();
            }
        }

        private void MontaLista()
        {
            //var lista = new ProxyPagadores().GetAll();
            //TotalRegistros = lista != null ? lista.Count() : 0;
            //rptEntity.DataSource = lista;
            //rptEntity.DataBind();
        }
    }
}