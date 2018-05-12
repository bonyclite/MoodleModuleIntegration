namespace Moodle3KL.Domain
{
    public class mdl_wiki_versions : mdl_entity_base {
        public long pageid { get; set; }
        public string content { get; set; }
        public string contentformat { get; set; }
        public int version { get; set; }
        public long timecreated { get; set; }
        public long userid { get; set; }
    }
}