using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YetzFlow.Web.Caller;

namespace YetzFlow.Web
{
    public partial class recuperarSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtEnvia_Click(object sender, EventArgs e)
        {
            LblMensagemDeErro.Text = "";
            string email = TxtEmail.Text;
            try
            {
                var usuario = new ProxyUsuarios().NovaSenha(email);
                if (usuario != null)
                {
                    Session["Usuario"] = usuario;
                }
                else
                {                    
                    LblMensagemDeErro.Text = "E-mail inválidos!";
                }
            }
            catch (Exception ex)
            {
                LblMensagemDeErro.Text = ex.Message;

            }
        }
    }
}