namespace Moodle3KL.Domain
{
    public class mdl_stats_daily : mdl_entity_base
    {
        public long courseid { get; set; }
        public long timeend { get; set; }
        public long roleid { get; set; }
        public string stattype { get; set; }
        public long stat1 { get; set; }
        public long stat2 { get; set; }
    }
}