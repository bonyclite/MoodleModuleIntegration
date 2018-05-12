namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_editpdf_annot
    {
        public long id { get; set; }
        public long gradeid { get; set; }
        public long pageno { get; set; }
        public long? x { get; set; }
        public long? y { get; set; }
        public long? endx { get; set; }
        public long? endy { get; set; }
        public string path { get; set; }
        public string type { get; set; }
        public string colour { get; set; }
        public short draft { get; set; }
    }
}