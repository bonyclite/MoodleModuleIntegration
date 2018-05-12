namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_p_choices : mdl_entity_base {
        public long scannedppageid { get; set; }
        public long? userid { get; set; }
        public short value { get; set; }
    }
}