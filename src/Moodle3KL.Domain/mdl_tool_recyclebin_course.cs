namespace Moodle3KL.Domain
{
    public class mdl_tool_recyclebin_course
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long section { get; set; }
        public long module { get; set; }
        public string name { get; set; }
        public long timecreated { get; set; }
    }
}