namespace Moodle3KL.Domain
{
    public class mdl_question_response_analysis : mdl_entity_base {
        public string hashcode { get; set; }
        public string whichtries { get; set; }
        public long timemodified { get; set; }
        public long questionid { get; set; }
        public long? variant { get; set; }
        public string subqid { get; set; }
        public string aid { get; set; }
        public string response { get; set; }
        public decimal credit { get; set; }
    }
}