namespace Moodle3KL.Domain
{
    public class mdl_workshop_aggregations : mdl_entity_base
    {
        public long workshopid { get; set; }
        public long userid { get; set; }
        public decimal? gradinggrade { get; set; }
        public long? timegraded { get; set; }
    }
}