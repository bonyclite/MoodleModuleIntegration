namespace Moodle3KL.Domain
{
    public class mdl_qtype_match_subquestions : mdl_entity_base
    {
        public long questionid { get; set; }
        public string questiontext { get; set; }
        public short questiontextformat { get; set; }
        public string answertext { get; set; }
    }
}