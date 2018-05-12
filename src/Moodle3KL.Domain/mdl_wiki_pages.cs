namespace Moodle3KL.Domain
{
    public class mdl_wiki_pages
    {
        public long id { get; set; }
        public long subwikiid { get; set; }
        public string title { get; set; }
        public string cachedcontent { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long timerendered { get; set; }
        public long userid { get; set; }
        public long pageviews { get; set; }
        public short @readonly { get; set; }
    }
}