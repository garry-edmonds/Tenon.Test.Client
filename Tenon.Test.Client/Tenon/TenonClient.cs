using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Tenon.Test.Client
{
    internal class TenonClient
    {
        private HttpClient Client { get; }
        private Uri TenonIoUrl { get; }

        internal TenonClient(Uri tenonIoUrl)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            Client = new HttpClient();
            TenonIoUrl = tenonIoUrl;
        }
        
        internal string Post(List<KeyValuePair<string, string>> content)
        {
            string responseBody;
            var encodedContent = new FormUrlEncodedContent(content);

            using (Client)
            {
                try
                {
                    var response = Client.PostAsync(TenonIoUrl, encodedContent).Result;
                    responseBody = response.Content.ReadAsStringAsync().Result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }
            }
            return responseBody;
        }
    }
}
