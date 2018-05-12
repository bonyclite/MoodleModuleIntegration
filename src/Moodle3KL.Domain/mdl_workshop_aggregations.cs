namespace Moodle3KL.Domain
{
    public class mdl_workshop_aggregations
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public long userid { get; set; }
        public decimal? gradinggrade { get; set; }
        public long? timegraded { get; set; }
    }
}