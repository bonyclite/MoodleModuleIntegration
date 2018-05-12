namespace Moodle3KL.Domain
{
    public class mdl_forum_discussion_subs
    {
        public long id { get; set; }
        public long forum { get; set; }
        public long userid { get; set; }
        public long discussion { get; set; }
        public long preference { get; set; }
    }
}