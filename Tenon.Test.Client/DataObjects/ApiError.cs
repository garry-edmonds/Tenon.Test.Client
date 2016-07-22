using System;

namespace Tenon.Test.Client.DataObjects
{
    public class ApiError
    {
        public int line { get; set; }
        public Uri sourceURL { get; set; }
        public string stack { get; set; }
        public int tID { get; set; }
    }
}
