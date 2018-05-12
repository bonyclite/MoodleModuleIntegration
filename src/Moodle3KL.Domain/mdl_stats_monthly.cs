namespace Moodle3KL.Domain
{
    public class mdl_stats_monthly
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long timeend { get; set; }
        public long roleid { get; set; }
        public string stattype { get; set; }
        public long stat1 { get; set; }
        public long stat2 { get; set; }
    }
}