namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_page_corners
    {
        public long id { get; set; }
        public long scannedpageid { get; set; }
        public short x { get; set; }
        public short y { get; set; }
        public short position { get; set; }
    }
}