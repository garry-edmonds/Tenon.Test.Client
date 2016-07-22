using System;

namespace Tenon.Test.Client.DataObjects
{
    public class Request
    {
        public Uri url { get; set; }
        public string @ref { get; set; }
        public string importance { get; set; }
        public string userID { get; set; }
        public string responseID { get; set; }
        public string projectID { get; set; }
        public string uaString { get; set; }
        public string docID { get; set; }
        public string level { get; set; }
        public string certainty { get; set; }
        public string priority { get; set; }
        public string waitFor { get; set; }
        public string fragment { get; set; }
        public string store { get; set; }
        public Viewport viewport { get; set; }
    }
}
