using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using YetzFlow.Site.Models;

namespace YetzFlow.Site.Caller
{
    public class ProxyNotasFiscais
    {
        public ProxyNotasFiscais()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        string apiUri = "api/notasfiscais";
        public List<Models.NotaFiscal> GetAll()
        {
            string uri = $"{apiUri}";
            return GetAllApi(uri, RestSharp.Method.GET);
        }

        public Models.NotaFiscal GetId(int id)
        {
            string uri = $"{apiUri}/{id}";
            return GetApi(uri, RestSharp.Method.GET);
        }

        public bool Save(Models.NotaFiscal entity)
        {
            if (entity.IdNotasFiscal > 0)
            {
                string uri = $"{apiUri}/{entity.IdNotasFiscal}";
                string body = JsonConvert.SerializeObject(entity);
                return ExecuteApi(uri, body, RestSharp.Method.PUT);
            }
            else
            {
                string uri = $"{apiUri}";
                string body = JsonConvert.SerializeObject(entity);
                return ExecuteApi(uri, body, RestSharp.Method.POST);
            }
        }

        public bool Delete(int id)
        {
            string uri = $"{apiUri}/id";

            return ExecuteApi(uri, "", RestSharp.Method.DELETE);
        }

        private bool ExecuteApi(string uri, string body, RestSharp.Method method)
        {
            var entity = ApiCaller.CallApi(uri, body, method);

            if (entity.StatusCode == HttpStatusCode.OK || entity.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<bool>(entity.Content);
            }
            else
            {
                string msg = $"Erro: {entity.StatusCode.ToString()} - [ {entity.Content} : {entity.ErrorMessage}]";
                throw new System.Exception(msg);
            }
        }

        private List<Models.NotaFiscal> GetAllApi(string uri, RestSharp.Method method)
        {
            var entity = ApiCaller.CallApi(uri, "", method);
            if (entity.StatusCode == HttpStatusCode.OK || entity.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<List<Models.NotaFiscal>>(entity.Content);
            }
            else
            {
                string msg = $"Erro: {entity.StatusCode.ToString()} - [ {entity.Content} : {entity.ErrorMessage}]";
                throw new System.Exception(msg);
            }
        }

        private Models.NotaFiscal GetApi(string uri, RestSharp.Method method)
        {
            var entity = ApiCaller.CallApi(uri, "", method);
            if (entity.StatusCode == HttpStatusCode.OK || entity.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<Models.NotaFiscal>(entity.Content);
            }
            else
            {
                string msg = $"Erro: {entity.StatusCode.ToString()} - [ {entity.Content} : {entity.ErrorMessage}]";
                throw new System.Exception(msg);
            }
        }
    }
}