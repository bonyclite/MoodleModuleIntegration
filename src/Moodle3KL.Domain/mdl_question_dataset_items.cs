namespace Moodle3KL.Domain
{
    public class mdl_question_dataset_items : mdl_entity_base
    {
        public long definition { get; set; }
        public long itemnumber { get; set; }
        public string value { get; set; }
    }
}