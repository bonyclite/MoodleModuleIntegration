namespace Moodle3KL.Domain
{
    public class mdl_tool_recyclebin_course : mdl_entity_base
    {
        public long courseid { get; set; }
        public long section { get; set; }
        public long module { get; set; }
        public string name { get; set; }
        public long timecreated { get; set; }
    }
}