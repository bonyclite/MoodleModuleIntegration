namespace Moodle3KL.Domain
{
    public class mdl_question_numerical
    {
        public long id { get; set; }
        public long question { get; set; }
        public long answer { get; set; }
        public string tolerance { get; set; }
    }
}