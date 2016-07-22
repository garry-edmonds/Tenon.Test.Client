using Newtonsoft.Json;
using System;
using System.Net;
using Tenon.Test.Client.DataObjects;
using Tenon.Test.Client.Settings;

namespace Tenon.Test.Client
{
    /// <summary>
    /// This is a wrapper around the Tenon.Io api.  For more info see.
    /// <a href:="https://tenon.io/documentation/overview.php">Tenon.IO documentation</a>
    /// </summary>
    public class TenonIO : OptionalParameters
    {
        internal override string _postData { get; set; }
        
        /// <summary>
        /// Run Tenon.IO Accessibility Tool, passing in a URL that is to be tested.
        /// </summary>
        /// <param name="apiKey">Tenon.IO api key.</param>
        /// <param name="urlToTest">The URL to be tested.</param>
        public TenonIO(string apiKey, Uri urlToTest)
        {
            _postData = ("url=" + urlToTest.ToString());
            _postData += ("&key=" + apiKey);
        }
        
        /// <summary>
        /// Run Tenon.IO Accessibility Tool, passing in the HTML source that is to be tested.
        /// </summary>
        /// <param name="apiKey">Tenon.IO api key.</param>
        /// <param name="pageSource">The HTML of the page to be tested.</param>
        public TenonIO(string apiKey, string pageSource)
        {
            _postData = ("src=" + pageSource);
            _postData += ("&key=" + apiKey);
        }
        
        /// <summary>
        /// Run the accessibility automation test, return json string.
        /// </summary>
        /// <returns>Json String value of the Api response from tenon.io.</returns>
        public string ExecuteTestJson()
        {
            byte[] data = HttpClient.InitialisePostData(_postData);
            var request = (HttpWebRequest)WebRequest.Create("https://tenon.io/api/");
            HttpClient.PostRequest(request, data);
            return HttpClient.GetResponse(request);
        }

        /// <summary>
        /// Run the accessibility test, return object structure of the response.
        /// </summary>
        /// <returns>Object structure of the Api response from tenon.io</returns>
        public ApiResponse ExecuteTest()
        {
            byte[] data = HttpClient.InitialisePostData(_postData);
            var request = (HttpWebRequest)WebRequest.Create("https://tenon.io/api/");
            HttpClient.PostRequest(request, data);
            return JsonConvert.DeserializeObject<ApiResponse>(HttpClient.GetResponse(request));
        }
        
    }
}
