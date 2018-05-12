namespace Moodle3KL.Domain
{
    public class mdl_upgrade_log
    {
        public long id { get; set; }
        public long type { get; set; }
        public string plugin { get; set; }
        public string version { get; set; }
        public string targetversion { get; set; }
        public string info { get; set; }
        public string details { get; set; }
        public string backtrace { get; set; }
        public long userid { get; set; }
        public long timemodified { get; set; }
    }
}