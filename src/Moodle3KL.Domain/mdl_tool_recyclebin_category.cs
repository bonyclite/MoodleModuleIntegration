namespace Moodle3KL.Domain
{
    public class mdl_tool_recyclebin_category
    {
        public long id { get; set; }
        public long categoryid { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public long timecreated { get; set; }
    }
}