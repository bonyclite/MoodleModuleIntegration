namespace Moodle3KL.Domain
{
    public class mdl_forum_read
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long forumid { get; set; }
        public long discussionid { get; set; }
        public long postid { get; set; }
        public long firstread { get; set; }
        public long lastread { get; set; }
    }
}