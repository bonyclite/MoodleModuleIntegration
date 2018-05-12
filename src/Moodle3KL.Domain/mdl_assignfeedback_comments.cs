namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_comments
    {
        public long id { get; set; }
        public long assignment { get; set; }
        public long grade { get; set; }
        public string commenttext { get; set; }
        public short commentformat { get; set; }
    }
}