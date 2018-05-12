namespace Moodle3KL.Domain
{
    public class mdl_forum_read : mdl_entity_base {
        public long userid { get; set; }
        public long forumid { get; set; }
        public long discussionid { get; set; }
        public long postid { get; set; }
        public long firstread { get; set; }
        public long lastread { get; set; }
    }
}