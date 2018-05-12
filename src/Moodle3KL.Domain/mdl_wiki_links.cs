namespace Moodle3KL.Domain
{
    public class mdl_wiki_links
    {
        public long id { get; set; }
        public long subwikiid { get; set; }
        public long frompageid { get; set; }
        public long topageid { get; set; }
        public string tomissingpage { get; set; }
    }
}