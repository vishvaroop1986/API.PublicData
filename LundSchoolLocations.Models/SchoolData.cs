namespace LundSchoolLocations.Models
{
    public class SchoolData
    {    
        public string next { get; set; }
        public int resultCount { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public int queryTime { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public string street { get; set; }
        public string postalcode { get; set; }
        public string name { get; set; }
        public string locality { get; set; }
        public string id { get; set; }
        public string source { get; set; }
        public string type { get; set; }
        public string operation { get; set; }
        public string latitude { get; set; }
        public string url { get; set; }
        public string longitude { get; set; }
    }
}