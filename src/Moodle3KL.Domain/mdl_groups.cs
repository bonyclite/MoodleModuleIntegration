namespace Moodle3KL.Domain
{
    public class mdl_groups : mdl_entity_base {
        public long courseid { get; set; }
        public string idnumber { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public string enrolmentkey { get; set; }
        public long picture { get; set; }
        public short hidepicture { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}