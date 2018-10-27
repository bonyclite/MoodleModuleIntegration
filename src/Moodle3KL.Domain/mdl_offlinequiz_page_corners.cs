namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_page_corners : mdl_entity_base
    {
        public long scannedpageid { get; set; }
        public short x { get; set; }
        public short y { get; set; }
        public short position { get; set; }
    }
}