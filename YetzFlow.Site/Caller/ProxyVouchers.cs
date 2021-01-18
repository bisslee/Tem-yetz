using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using YetzFlow.Site.Models;

namespace YetzFlow.Site.Caller
{
    public class ProxyVouchers
    {
        public ProxyVouchers()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        string apiUri = "api/vouchers";

        public List<Models.Voucher> GetAll()
        {
            string uri = $"{apiUri}";
            return GetAllApi(uri, RestSharp.Method.GET);
        }

        public Models.Voucher GetId(int id)
        {
            string uri = $"{apiUri}/{id}";
            return GetApi(uri, RestSharp.Method.GET);
        }

        public bool Save(Models.Voucher entity)
        {
            if (entity.IdVoucher > 0)
            {
                string uri = $"{apiUri}/{entity.IdVoucher}";
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

        private List<Models.Voucher> GetAllApi(string uri, RestSharp.Method method)
        {
            var entity = ApiCaller.CallApi(uri, "", method);
            if (entity.StatusCode == HttpStatusCode.OK || entity.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<List<Models.Voucher>>(entity.Content);
            }
            else
            {
                string msg = $"Erro: {entity.StatusCode.ToString()} - [ {entity.Content} : {entity.ErrorMessage}]";
                throw new System.Exception(msg);
            }
        }

        private Models.Voucher GetApi(string uri, RestSharp.Method method)
        {
            var entity = ApiCaller.CallApi(uri, "", method);
            if (entity.StatusCode == HttpStatusCode.OK || entity.StatusCode == HttpStatusCode.NoContent)
            {
                return JsonConvert.DeserializeObject<Models.Voucher>(entity.Content);
            }
            else
            {
                string msg = $"Erro: {entity.StatusCode.ToString()} - [ {entity.Content} : {entity.ErrorMessage}]";
                throw new System.Exception(msg);
            }
        }
    }
}