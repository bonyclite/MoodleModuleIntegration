namespace Moodle3KL.Domain
{
    public class mdl_quiz_reports : mdl_entity_base
    {
        public string name { get; set; }
        public long displayorder { get; set; }
        public string capability { get; set; }
    }
}