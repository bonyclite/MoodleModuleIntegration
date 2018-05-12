namespace Moodle3KL.Domain
{
    public class mdl_wiki_locks
    {
        public long id { get; set; }
        public long pageid { get; set; }
        public string sectionname { get; set; }
        public long userid { get; set; }
        public long lockedat { get; set; }
    }
}