namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_editpdf_cmnt
    {
        public long id { get; set; }
        public long gradeid { get; set; }
        public long? x { get; set; }
        public long? y { get; set; }
        public long? width { get; set; }
        public string rawtext { get; set; }
        public long pageno { get; set; }
        public string colour { get; set; }
        public short draft { get; set; }
    }
}