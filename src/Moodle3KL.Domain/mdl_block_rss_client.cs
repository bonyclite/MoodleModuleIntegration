namespace Moodle3KL.Domain
{
    public class mdl_block_rss_client : mdl_entity_base
    {
        public long userid { get; set; }
        public string title { get; set; }
        public string preferredtitle { get; set; }
        public string description { get; set; }
        public short shared { get; set; }
        public string url { get; set; }
        public long skiptime { get; set; }
        public long skipuntil { get; set; }
    }
}