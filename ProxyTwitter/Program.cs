using ProxyTwitter.Models;
using System;

namespace ProxyTwitter
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyTwitt();
            var response = proxy.ObtenerTweets("flower");

            foreach (var tw in response)
            {
                Console.WriteLine($"Tweet: {tw.previewURL}");
            }
        }
    }
}
