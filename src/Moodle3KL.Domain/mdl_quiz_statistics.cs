namespace Moodle3KL.Domain
{
    public class mdl_quiz_statistics
    {
        public long id { get; set; }
        public string hashcode { get; set; }
        public short whichattempts { get; set; }
        public long timemodified { get; set; }
        public long firstattemptscount { get; set; }
        public long highestattemptscount { get; set; }
        public long lastattemptscount { get; set; }
        public long allattemptscount { get; set; }
        public decimal? firstattemptsavg { get; set; }
        public decimal? highestattemptsavg { get; set; }
        public decimal? lastattemptsavg { get; set; }
        public decimal? allattemptsavg { get; set; }
        public decimal? median { get; set; }
        public decimal? standarddeviation { get; set; }
        public decimal? skewness { get; set; }
        public decimal? kurtosis { get; set; }
        public decimal? cic { get; set; }
        public decimal? errorratio { get; set; }
        public decimal? standarderror { get; set; }
    }
}