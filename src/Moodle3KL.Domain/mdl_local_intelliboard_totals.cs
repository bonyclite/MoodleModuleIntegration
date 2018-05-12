namespace Moodle3KL.Domain
{
    public class mdl_local_intelliboard_totals : mdl_entity_base
    {
        public long? sessions { get; set; }
        public long? courses { get; set; }
        public long? visits { get; set; }
        public long? timespend { get; set; }
        public long? timepoint { get; set; }
    }
}