namespace Moodle3KL.Domain
{
    public class mdl_cache_flags
    {
        public long id { get; set; }
        public string flagtype { get; set; }
        public string name { get; set; }
        public long timemodified { get; set; }
        public string value { get; set; }
        public long expiry { get; set; }
    }
}