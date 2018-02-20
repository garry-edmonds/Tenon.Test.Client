using System;
using System.IO;
using System.Net;
using System.Text;

namespace Tenon.Test.Client
{
    internal static class HttpClient
    {
        internal static byte[] InitialisePostData(string postData)
        {
            var encoding = Encoding.GetEncoding("UTF-8");
            return encoding.GetBytes(postData);
        }

        internal static void PostRequest(HttpWebRequest request, byte[] postData)
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            request.Headers["Cache-Control"] = "no-cache";
            using (var stream = request.GetRequestStream())
            {
                stream.Write(postData, 0, postData.Length);
            }
        }

        internal static string GetResponse(HttpWebRequest request)
        {
            var responseFromServer = string.Empty;
            using (WebResponse response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        responseFromServer = reader.ReadToEnd();
                        Console.WriteLine(responseFromServer);
                    }
                }
            }
            return responseFromServer;
        }
    }
}
