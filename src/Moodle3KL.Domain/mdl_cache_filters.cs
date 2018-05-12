namespace Moodle3KL.Domain
{
    public class mdl_cache_filters
    {
        public long id { get; set; }
        public string filter { get; set; }
        public long version { get; set; }
        public string md5key { get; set; }
        public string rawtext { get; set; }
        public long timemodified { get; set; }
    }
}