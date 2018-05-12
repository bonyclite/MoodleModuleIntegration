namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_hotspots : mdl_entity_base {
        public long scannedpageid { get; set; }
        public string name { get; set; }
        public decimal x { get; set; }
        public decimal y { get; set; }
        public short? blank { get; set; }
        public long time { get; set; }
    }
}