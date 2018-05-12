namespace Moodle3KL.Domain
{
    public class mdl_lti_tool_settings : mdl_entity_base
    {
        public long toolproxyid { get; set; }
        public long? course { get; set; }
        public long? coursemoduleid { get; set; }
        public string settings { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}