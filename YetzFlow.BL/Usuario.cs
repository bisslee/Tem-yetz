using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class Usuario : IUsuario
    {
        private readonly string connstring;
        public Usuario(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<Entity.Usuario> Login(string email, string senha)
        {
            var senhaFinal = $"{email}:{senha}".ComputeSha256Hash();

            return await new DB.Usuario(connstring).Login(email, senhaFinal);
        }

        public async Task<Entity.Usuario> NewPassowrd(string email)
        {
            var novaSenha = Guid.NewGuid().ToString().Substring(0, 8);

            var senhaFinal = $"{email}:{novaSenha}".ComputeSha256Hash();
            var envio = new Email().SendEmail(email, novaSenha);
            if (envio != "OK")
            {
               throw new Exception(envio);
            }
            
            return await new DB.Usuario(connstring).NewPassowrd(email, senhaFinal);
        }
    }
}
