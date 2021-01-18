using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Site.Caller;
using YetzFlow.Site.Extensions;
using YetzFlow.Site.Models;

namespace YetzFlow.Site
{
    public partial class Pagadores : System.Web.UI.Page
    {
        public int TotalRegistros { get; set; }
        public string NomePagina { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NomePagina = "Pagadores";
            Session["NomePagina"] = NomePagina;

            if (!IsPostBack)
            {
                MontaLista();
            }
        }

        private void MontaLista()
        {
            var lista =  new ProxyPagadores().GetAll();
            TotalRegistros = lista != null ? lista.Count() : 0;
            rptEntity.DataSource = lista;
            rptEntity.DataBind();
        }

        protected void rptEntity_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {           
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //Reference the Repeater Item.
                RepeaterItem item = e.Item;

                //Reference the Controls.
                var btEdit = (ImageButton)item.FindControl("BtEdit") ;
                var btDelete = (ImageButton)item.FindControl("BtDelete");

                btEdit.CommandArgument = ((Pagador)e.Item.DataItem).IdPagador.ToString().Crypt();
                btDelete.CommandArgument = ((Pagador)e.Item.DataItem).IdPagador.ToString().Crypt();
            }
        }

        protected void rptEntity_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                DeleteEntity(e.CommandArgument.ToString());
            }

            if (e.CommandName == "edit")
            {
                UpdateEntity(e.CommandArgument.ToString());
            }
        }

        private void UpdateEntity(string id)
        {
            Response.Redirect($"PagadoresForm.aspx?Edit={id}");
        }

        private void DeleteEntity(string v)
        {
            throw new NotImplementedException();
        }
    }
}