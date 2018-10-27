namespace Moodle3KL.Domain
{
    public class mdl_forum_track_prefs : mdl_entity_base
    {
        public long userid { get; set; }
        public long forumid { get; set; }
    }
}