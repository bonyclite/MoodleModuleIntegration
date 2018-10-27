namespace Moodle3KL.Domain
{
    public class mdl_question_truefalse : mdl_entity_base
    {
        public long question { get; set; }
        public long trueanswer { get; set; }
        public long falseanswer { get; set; }
    }
}