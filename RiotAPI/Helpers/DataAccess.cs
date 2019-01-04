using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace RiotAPI.Helpers
{
    public static class DataAccess
    {
        public static string GetFromREST(string url)
        {
            var client = new RestClient
            {
                BaseUrl = new Uri(url)
            };
            IRestResponse response = client.Execute(new RestRequest());
            return response.Content;
        }
    }
}