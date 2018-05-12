namespace Moodle3KL.Domain
{
    public class mdl_question_hints
    {
        public long id { get; set; }
        public long questionid { get; set; }
        public string hint { get; set; }
        public short hintformat { get; set; }
        public short? shownumcorrect { get; set; }
        public short? clearwrong { get; set; }
        public string options { get; set; }
    }
}