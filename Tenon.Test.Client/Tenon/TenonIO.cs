using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
        private readonly Uri _tenonIoUrl = new Uri("https://tenon.io/api/");
        internal sealed override List<KeyValuePair<string, string>> Content { get; set; }

        /// <summary>
        /// Run Tenon.IO Accessibility Tool, passing in a URL that is to be tested.
        /// </summary>
        /// <param name="apiKey">Tenon.IO api key.</param>
        /// <param name="urlToTest">The URL to be tested.</param>
        public TenonIO(string apiKey, Uri urlToTest)
        {
            Content = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("key", apiKey),
                new KeyValuePair<string, string>("url", urlToTest.ToString())
            };
        }
        
        /// <summary>
        /// Run Tenon.IO Accessibility Tool, passing in the HTML source that is to be tested.
        /// </summary>
        /// <param name="apiKey">Tenon.IO api key.</param>
        /// <param name="pageSource">The HTML of the page to be tested.</param>
        public TenonIO(string apiKey, string pageSource)
        {
            Content = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("key", apiKey),
                new KeyValuePair<string, string>("src", pageSource)
            };
        }

        /// <summary>
        /// Run the accessibility automation test, return json string.
        /// </summary>
        /// <returns>Json String value of the Api response from tenon.io.</returns>
        public string ExecuteTestJson()
        {
            var client = new TenonClient(_tenonIoUrl);
            return client.Post(Content);
        }

        /// <summary>
        /// Run the accessibility test, return object structure of the response.
        /// </summary>
        /// <returns>Object structure of the Api response from tenon.io</returns>
        public ApiResponse ExecuteTest()
        {
            return JsonConvert.DeserializeObject<ApiResponse>(ExecuteTestJson());
        }
        
    }
}
