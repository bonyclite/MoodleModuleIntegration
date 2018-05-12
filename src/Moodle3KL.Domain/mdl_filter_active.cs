namespace Moodle3KL.Domain
{
    public class mdl_filter_active
    {
        public long id { get; set; }
        public string filter { get; set; }
        public long contextid { get; set; }
        public short active { get; set; }
        public long sortorder { get; set; }
    }
}