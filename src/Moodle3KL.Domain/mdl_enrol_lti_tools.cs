namespace Moodle3KL.Domain
{
    public class mdl_enrol_lti_tools : mdl_entity_base {
        public long enrolid { get; set; }
        public long contextid { get; set; }
        public string institution { get; set; }
        public string lang { get; set; }
        public string timezone { get; set; }
        public long maxenrolled { get; set; }
        public short maildisplay { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public short gradesync { get; set; }
        public short gradesynccompletion { get; set; }
        public short membersync { get; set; }
        public short membersyncmode { get; set; }
        public long roleinstructor { get; set; }
        public long rolelearner { get; set; }
        public string secret { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}