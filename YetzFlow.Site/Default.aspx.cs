using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Site.Caller;

namespace YetzFlow.Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtLogin_Click(object sender, EventArgs e)
        {
            LblMensagemDeErro.Text = "";
            string email = TxtEmail.Text;
            string senha = TxtSenha.Text;
            try
            {
                var usuario = new ProxyUsuarios().Login(email, senha);
                if (usuario != null)
                {
                    Session["Usuario"] = usuario;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    LblMensagemDeErro.Text = "E-mail ou senha inválidos!";
                    LblMensagemDeErro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                LblMensagemDeErro.Text = ex.Message;
                LblMensagemDeErro.Visible = true;
            }
        }
    }
}