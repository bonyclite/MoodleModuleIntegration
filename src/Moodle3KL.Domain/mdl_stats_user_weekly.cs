namespace Moodle3KL.Domain
{
    public class mdl_stats_user_weekly : mdl_entity_base
    {
        public long courseid { get; set; }
        public long userid { get; set; }
        public long roleid { get; set; }
        public long timeend { get; set; }
        public long statsreads { get; set; }
        public long statswrites { get; set; }
        public string stattype { get; set; }
    }
}