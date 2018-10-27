namespace Moodle3KL.Domain
{
    public class mdl_forum_queue : mdl_entity_base
    {
        public long userid { get; set; }
        public long discussionid { get; set; }
        public long postid { get; set; }
        public long timemodified { get; set; }
    }
}