namespace Moodle3KL.Domain
{
    public class mdl_block_recent_activity
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long cmid { get; set; }
        public long timecreated { get; set; }
        public long userid { get; set; }
        public short action { get; set; }
        public string modname { get; set; }
    }
}