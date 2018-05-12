namespace Moodle3KL.Domain
{
    public class mdl_blog_external : mdl_entity_base {
        public long userid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string filtertags { get; set; }
        public short failedlastsync { get; set; }
        public long? timemodified { get; set; }
        public long timefetched { get; set; }
    }
}