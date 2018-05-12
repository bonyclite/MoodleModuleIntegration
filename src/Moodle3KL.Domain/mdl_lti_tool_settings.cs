namespace Moodle3KL.Domain
{
    public class mdl_lti_tool_settings
    {
        public long id { get; set; }
        public long toolproxyid { get; set; }
        public long? course { get; set; }
        public long? coursemoduleid { get; set; }
        public string settings { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}