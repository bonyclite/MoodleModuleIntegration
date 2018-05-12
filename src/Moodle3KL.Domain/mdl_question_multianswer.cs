namespace Moodle3KL.Domain
{
    public class mdl_question_multianswer : mdl_entity_base {
        public long question { get; set; }
        public string sequence { get; set; }
    }
}