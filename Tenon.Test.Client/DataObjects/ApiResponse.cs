using System;
using System.Collections.Generic;

namespace Tenon.Test.Client.DataObjects
{
    public class ApiResponse
    {
        public List<ApiError> apiErrors { get; set; }
        public int documentSize { get; set; }
        public GlobalStats globalStats { get; set; }
        public string message { get; set; }
        public Request request { get; set; }
        public decimal responseExecTime { get; set; }
        public DateTime responseTime { get; set; }
        public List<ResultSet> resultSet { get; set; }
        public ResultSummary resultSummary { get; set; }
        public string sourceHash { get; set; }
        public int status { get; set; }
        public List<object> clientScriptErrors { get; set; }
        public string code { get; set; }
        public Uri moreInfo { get; set; }
    }
        
}
