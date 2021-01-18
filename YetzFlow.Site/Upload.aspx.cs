using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YetzFlow.Site
{
    public partial class Upload : System.Web.UI.Page
    {
        public string NomePagina { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NomePagina = "Upload";
           // Master.NomePagina = NomePagina;

        }
    }
}