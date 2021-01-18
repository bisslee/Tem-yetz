using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Site.Caller;
using YetzFlow.Site.Extensions;

namespace YetzFlow.Site
{
    public partial class PagadoresForm : System.Web.UI.Page
    {
        public int TotalRegistros { get; set; }
        public string NomePagina { get; set; }
        public static int IdEntity { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            NomePagina = "Pagadores";
            Session["NomePagina"] = NomePagina;

            if (!IsPostBack)
            {
                if (Request.QueryString["Edit"] != null)
                {
                    IdEntity = int.Parse(Request.QueryString["Edit"].ToString().Decrypt());
                    MontaEntity(IdEntity);
                }
            }
        }

        private void MontaEntity(int id)
        {
            var entity = new ProxyPagadores().GetId(id);
            nomePagador.Text = entity.Nome;
            cnpjPagador.Text = entity.CNPJ;
            emailPagador.Text = entity.Email;
            telefonePagador.Text = entity.Telefone;
            contatoPagador.Text = entity.Contato;
            contatoCelular.Text = entity.Celular;
            hndID.Value = id.ToString();
        }

        protected void BtSalvar_Click(object sender, EventArgs e)
        {

            var entity = new Models.Pagador()
            {
                Nome = nomePagador.Text,
                CNPJ = cnpjPagador.Text,
                Email = emailPagador.Text,
                Telefone = telefonePagador.Text,
                Contato = contatoPagador.Text,
                Celular = contatoCelular.Text,
                IdUsuarioAtualizacao = ((Models.Usuario)Session["Usuario"]).IdUsuario,
                IdUsuarioCriacao = ((Models.Usuario)Session["Usuario"]).IdUsuario
            };

            if (!string.IsNullOrEmpty(hndID.Value))
            {
                entity.IdPagador = int.Parse(hndID.Value);
            }

            try
            {
                new ProxyPagadores().Save(entity);
                Response.Redirect($"Pagadores.aspx");
            }
            catch (Exception ex)
            {
                //mensagem
                throw;
            }

        }

        protected void BtCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Pagadores.aspx");
        }
    }
}