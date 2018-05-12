namespace Moodle3KL.Domain
{
    public class mdl_grade_outcomes
    {
        public long id { get; set; }
        public long? courseid { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public long? scaleid { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long? timecreated { get; set; }
        public long? timemodified { get; set; }
        public long? usermodified { get; set; }
    }
}