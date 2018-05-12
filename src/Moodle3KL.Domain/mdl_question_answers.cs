namespace Moodle3KL.Domain
{
    public class mdl_question_answers
    {
        public long id { get; set; }
        public long question { get; set; }
        public string answer { get; set; }
        public short answerformat { get; set; }
        public decimal fraction { get; set; }
        public string feedback { get; set; }
        public short feedbackformat { get; set; }
    }
}