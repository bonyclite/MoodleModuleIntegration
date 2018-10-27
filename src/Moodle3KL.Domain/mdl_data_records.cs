namespace Moodle3KL.Domain
{
    public class mdl_data_records : mdl_entity_base
    {
        public long userid { get; set; }
        public long groupid { get; set; }
        public long dataid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short approved { get; set; }
    }
}