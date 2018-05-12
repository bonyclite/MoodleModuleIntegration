namespace Moodle3KL.Domain
{
    public class mdl_otcourselogic_state : mdl_entity_base {
        public long instanceid { get; set; }
        public long userid { get; set; }
        public short active { get; set; }
        public long? activelastchange { get; set; }
        public long? lastcheck { get; set; }
        public long? lastdeliver { get; set; }
    }
}