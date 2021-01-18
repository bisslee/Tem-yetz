using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using YetzFlow.Site.Models;

namespace YetzFlow.Site.Caller
{
    public class ProxyUsuarios
    {
        public ProxyUsuarios()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        string apiUri = "api/usuarios";
        public Usuario Login(string email, string senha)
        {
            string body = $"{apiUri}/{email}/?senha={senha}";
            return GetUsuarioApi(body, RestSharp.Method.GET);
        }
        public Usuario NovaSenha(string email)
        {
            string body = $"{apiUri}/{email}";
            return GetUsuarioApi(body, RestSharp.Method.PUT);
        }
        private Usuario GetUsuarioApi(string uri, RestSharp.Method method)
        {
            var usuario = ApiCaller.CallApi(uri,"", method);
            if (usuario.StatusCode == HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<Usuario>(usuario.Content);
            }
            else
            {
                string msg = $"Erro: {usuario.StatusCode.ToString()} - [ {usuario.Content} : {usuario.ErrorMessage}]";
                throw new System.Exception(msg);
            }
        }
    }
}