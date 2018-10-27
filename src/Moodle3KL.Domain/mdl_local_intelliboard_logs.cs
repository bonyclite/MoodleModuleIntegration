namespace Moodle3KL.Domain
{
    public class mdl_local_intelliboard_logs : mdl_entity_base
    {
        public long? trackid { get; set; }
        public long? visits { get; set; }
        public long? timespend { get; set; }
        public long? timepoint { get; set; }
    }
}