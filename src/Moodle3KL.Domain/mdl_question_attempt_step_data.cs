namespace Moodle3KL.Domain
{
    public class mdl_question_attempt_step_data : mdl_entity_base {
        public long attemptstepid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}