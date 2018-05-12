namespace Moodle3KL.Domain
{
    public class mdl_wiki_subwikis : mdl_entity_base {
        public long wikiid { get; set; }
        public long groupid { get; set; }
        public long userid { get; set; }
    }
}