namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_statistics : mdl_entity_base {
        public long offlinequizid { get; set; }
        public long? offlinegroupid { get; set; }
        public long groupid { get; set; }
        public short allattempts { get; set; }
        public long timemodified { get; set; }
        public long firstattemptscount { get; set; }
        public long allattemptscount { get; set; }
        public decimal? firstattemptsavg { get; set; }
        public decimal? median { get; set; }
        public decimal? allattemptsavg { get; set; }
        public decimal? standarddeviation { get; set; }
        public decimal? skewness { get; set; }
        public decimal? kurtosis { get; set; }
        public decimal? cic { get; set; }
        public decimal? errorratio { get; set; }
        public decimal? standarderror { get; set; }
        public decimal? bestgrade { get; set; }
        public decimal? worstgrade { get; set; }
    }
}