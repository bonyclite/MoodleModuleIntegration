namespace Moodle3KL.Domain
{
    public class mdl_context
    {
        public long id { get; set; }
        public long contextlevel { get; set; }
        public long instanceid { get; set; }
        public string path { get; set; }
        public short depth { get; set; }
    }
}