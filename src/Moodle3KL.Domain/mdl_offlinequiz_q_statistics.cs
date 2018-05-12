namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_q_statistics : mdl_entity_base {
        public long offlinequizstatisticsid { get; set; }
        public long questionid { get; set; }
        public long? slot { get; set; }
        public short subquestion { get; set; }
        public long s { get; set; }
        public decimal? effectiveweight { get; set; }
        public short negcovar { get; set; }
        public decimal? discriminationindex { get; set; }
        public decimal? discriminativeefficiency { get; set; }
        public decimal? sd { get; set; }
        public decimal? facility { get; set; }
        public string subquestions { get; set; }
        public decimal? maxmark { get; set; }
        public string positions { get; set; }
        public decimal? randomguessscore { get; set; }
        public short? correct { get; set; }
        public short? partially { get; set; }
        public short? wrong { get; set; }
    }
}