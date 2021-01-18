using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Site.Caller;

namespace YetzFlow.Site
{
    public partial class RecuperarSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtEnvia_Click(object sender, EventArgs e)
        {
            LblMensagem.Text = "";
            string email = TxtEmail.Text;
            try
            {
                var usuario = new ProxyUsuarios().NovaSenha(email);
                if (usuario != null)
                {
                    Session["Usuario"] = usuario;
                    LblMensagem.Text = "Nova Senha enviada para seu e-mail!";
                    LblMensagem.CssClass = "alert-success";
                    LblMensagem.Visible = true;
                }
                else
                {
                    LblMensagem.Text = "E-mail inválidos!";
                    LblMensagem.CssClass = "alert-danger";
                    LblMensagem.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LblMensagem.Text = ex.Message;
                LblMensagem.CssClass = "alert-danger";
                LblMensagem.Visible = true;
            }
        }
    }
}