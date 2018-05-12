namespace Moodle3KL.Domain
{
    public class mdl_wiki_synonyms : mdl_entity_base
    {
        public long subwikiid { get; set; }
        public long pageid { get; set; }
        public string pagesynonym { get; set; }
    }
}