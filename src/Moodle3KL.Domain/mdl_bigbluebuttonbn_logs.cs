namespace Moodle3KL.Domain
{
    public class mdl_bigbluebuttonbn_logs : mdl_entity_base {
        public long courseid { get; set; }
        public long bigbluebuttonbnid { get; set; }
        public long? userid { get; set; }
        public long timecreated { get; set; }
        public string meetingid { get; set; }
        public string log { get; set; }
        public string meta { get; set; }
    }
}