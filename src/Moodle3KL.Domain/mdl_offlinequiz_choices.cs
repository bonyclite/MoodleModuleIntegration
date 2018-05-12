namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_choices : mdl_entity_base {
        public long scannedpageid { get; set; }
        public short slotnumber { get; set; }
        public short choicenumber { get; set; }
        public short value { get; set; }
    }
}