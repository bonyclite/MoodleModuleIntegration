namespace Moodle3KL.Domain
{
    public class mdl_feedback_completedtmp : mdl_entity_base
    {
        public long feedback { get; set; }
        public long userid { get; set; }
        public string guestid { get; set; }
        public long timemodified { get; set; }
        public long random_response { get; set; }
        public short anonymous_response { get; set; }
        public long courseid { get; set; }
    }
}