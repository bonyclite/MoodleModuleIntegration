namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_q_response_stats : mdl_entity_base
    {
        public long offlinequizstatisticsid { get; set; }
        public long questionid { get; set; }
        public string subqid { get; set; }
        public string aid { get; set; }
        public string response { get; set; }
        public long? rcount { get; set; }
        public decimal credit { get; set; }
    }
}