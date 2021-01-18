using System;
using System.Configuration;

namespace YetzFlow.SimpleTest
{
    class Program
    {
        static string connString = ConfigurationManager.ConnectionStrings"connString"].ToString();
        static void Main(string] args)
        {           
            //var usuarioBissGm = new DB.Usuario(connString).Login("bisslee@gmail.com","123456");
            //var usuarioBissHot = new DB.Usuario(connString).Login("bisslee@hotmail.com", "123456");
            //usuarioBissHot = new DB.Usuario(connString).Login("bisslee@hotmail.com", "654321");
            //var usuarioMarco = new DB.Usuario(connString).Login("marco.nicola@workarea.com.br", "123456");
            //var novaSenhausuario= new Core.Usuario(connString).NewPassowrd("bisslee@hotmail.com");

            var usuarioBissHot = new Core.Usuario(connString).Login("bisslee@hotmail.com", "7b5011e4d");

        }
    }
}
