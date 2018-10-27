namespace Moodle3KL.Domain
{
    public class mdl_wiki_locks : mdl_entity_base
    {
        public long pageid { get; set; }
        public string sectionname { get; set; }
        public long userid { get; set; }
        public long lockedat { get; set; }
    }
}