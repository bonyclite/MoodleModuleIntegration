namespace Moodle3KL.Domain
{
    public class mdl_question_numerical : mdl_entity_base
    {
        public long question { get; set; }
        public long answer { get; set; }
        public string tolerance { get; set; }
    }
}