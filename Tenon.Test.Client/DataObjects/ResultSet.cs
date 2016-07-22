using System;
using System.Collections.Generic;

namespace Tenon.Test.Client.DataObjects
{
    public class ResultSet
    {
        public int bpID { get; set; }
        public int certainty { get; set; }
        public string errorDescription { get; set; }
        public string errorSnippet { get; set; }
        public string errorTitle { get; set; }
        public Position position { get; set; }
        public int priority { get; set; }
        public Uri @ref { get; set; }
        public string resultTitle { get; set; }
        public string signature { get; set; }
        public List<string> standards { get; set; }
        public int tID { get; set; }
        public string xpath { get; set; }
    }
}
