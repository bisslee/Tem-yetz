using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.DB.Interface
{
    public interface IUsuario
    {
        Task<Entity.Usuario> Login(string email, string senha);
        Task<Entity.Usuario> NewPassowrd(string email, string novaSenha);
    }
}
