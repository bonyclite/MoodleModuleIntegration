namespace Moodle3KL.Domain
{
    public class mdl_wiki_synonyms
    {
        public long id { get; set; }
        public long subwikiid { get; set; }
        public long pageid { get; set; }
        public string pagesynonym { get; set; }
    }
}