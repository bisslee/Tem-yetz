using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Site.Models;

namespace YetzFlow.Site
{
    public partial class YetzFlow : System.Web.UI.MasterPage
    {
        public string NomeUsuario { get; set; }
        public string NomePagina { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"]!=null)
            {
                NomeUsuario = ((Usuario)Session["Usuario"]).Nome;
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void HlnkLogout_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}