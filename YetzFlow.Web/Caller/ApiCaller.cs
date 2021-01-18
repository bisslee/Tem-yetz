using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace YetzFlow.Web.Caller
{
    public static class ApiCaller
    {
        static readonly string url = ConfigurationManager.AppSettings["EnderecoApi"].ToString();

        public static IRestResponse CallApi(string body, RestSharp.Method method)
        {
            var client = new RestClient(url);

            var request = new RestRequest(body, method);

            return client.Execute(request);

        }
    }
}