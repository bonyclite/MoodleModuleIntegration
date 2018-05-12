namespace Moodle3KL.Domain
{
    public class mdl_qtype_shortanswer_options : mdl_entity_base
    {
        public long questionid { get; set; }
        public short usecase { get; set; }
    }
}