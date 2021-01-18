using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YetzFlow.Site
{
    public partial class CampanhasForm : System.Web.UI.Page
    {
        public int TotalRegistros { get; set; }
        public string NomePagina { get; set; }

        public int id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NomePagina = "Campanhas";
            Session["NomePagina"] = NomePagina;


        }
    }
}