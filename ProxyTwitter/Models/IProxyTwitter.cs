using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyTwitter.Models
{
    public interface IProxyTwitter
    {
        List<Twitt> ObtenerTweets(string usuario);
    }
}
