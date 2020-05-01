using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyTwitter.Models
{
    public class ProxyTwitt : IProxyTwitter
    {
        private RestClient _client;
        private string _key = "16275820-26d58350ac6515836d047fcad";
        private string _imagetype = "photo";
        private string _urlBase = "https://pixabay.com/api/";

        public ProxyTwitt()
        {
            _client = new RestClient(_urlBase);
        }
        public List<Twitt> ObtenerTweets(string usuario)
        {
            var request = new RestRequest($"?key={_key}&q={usuario}&image_type={_imagetype}");
            var response = _client.Get<TwittRequest>(request);
            return response.Data.hits;

        }
    }
}
