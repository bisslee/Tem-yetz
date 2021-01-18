using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace YetzFlow.Site.Caller
{
    public static class ApiCaller
    {
        static readonly string urlProd = ConfigurationManager.AppSettings["EnderecoApiProd"].ToString();
        static readonly string urlDev = ConfigurationManager.AppSettings["EnderecoApiDev"].ToString();
        public static string URL()
        {
            var url = HttpContext.Current.Request.Url.AbsoluteUri;
            return url.IndexOf("localhost") > 0 ? urlDev : urlProd;
        }
        public static IRestResponse CallApi(string uri, string body, RestSharp.Method method)
        {
            var client = new RestClient(URL() + uri);

            if (method == Method.GET)
            {
                var request = new RestRequest(body, method);       
                return client.Execute(request);
            }
            else
            {
                var request = new RestRequest();
                request.Method = method;
                request.AddHeader("Accept", "application/json");
                request.Parameters.Clear();
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                var response = client.Execute(request);
                
                return response;
            }

        }
    }
}