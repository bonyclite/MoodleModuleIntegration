namespace Moodle3KL.Domain
{
    public class mdl_question_numerical_options
    {
        public long id { get; set; }
        public long question { get; set; }
        public short showunits { get; set; }
        public short unitsleft { get; set; }
        public short unitgradingtype { get; set; }
        public decimal unitpenalty { get; set; }
    }
}