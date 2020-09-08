using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Web;

namespace ReadOnlineApi
{
    public static class GlobalVariables
    {

        public static HttpClient WebApiClient = new HttpClient();

        static GlobalVariables()
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(
            delegate { return true; }
        );

            string webApiUrl = ConfigurationManager.AppSettings["WebApiUrl"];
            WebApiClient.BaseAddress = new Uri(webApiUrl);

            TimeSpan hour = new TimeSpan(1, 0, 0);
            WebApiClient.Timeout = hour;

            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}