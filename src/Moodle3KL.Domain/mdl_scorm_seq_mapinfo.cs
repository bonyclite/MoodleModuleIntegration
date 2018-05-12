namespace Moodle3KL.Domain
{
    public class mdl_scorm_seq_mapinfo
    {
        public long id { get; set; }
        public long scoid { get; set; }
        public long objectiveid { get; set; }
        public long targetobjectiveid { get; set; }
        public short readsatisfiedstatus { get; set; }
        public short readnormalizedmeasure { get; set; }
        public short writesatisfiedstatus { get; set; }
        public short writenormalizedmeasure { get; set; }
    }
}