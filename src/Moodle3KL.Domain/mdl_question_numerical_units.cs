namespace Moodle3KL.Domain
{
    public class mdl_question_numerical_units : mdl_entity_base
    {
        public long question { get; set; }
        public decimal multiplier { get; set; }
        public string unit { get; set; }
    }
}