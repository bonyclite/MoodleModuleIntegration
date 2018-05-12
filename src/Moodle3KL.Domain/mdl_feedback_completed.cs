namespace Moodle3KL.Domain
{
    public class mdl_feedback_completed
    {
        public long id { get; set; }
        public long feedback { get; set; }
        public long userid { get; set; }
        public long timemodified { get; set; }
        public long random_response { get; set; }
        public short anonymous_response { get; set; }
        public long courseid { get; set; }
    }
}