namespace Moodle3KL.Domain
{
    public class mdl_tool_customlang : mdl_entity_base
    {
        public string lang { get; set; }
        public long componentid { get; set; }
        public string stringid { get; set; }
        public string original { get; set; }
        public string master { get; set; }
        public string local { get; set; }
        public long timemodified { get; set; }
        public long? timecustomized { get; set; }
        public short? outdated { get; set; }
        public short? modified { get; set; }
    }
}