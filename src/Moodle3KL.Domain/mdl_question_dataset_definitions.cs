namespace Moodle3KL.Domain
{
    public class mdl_question_dataset_definitions : mdl_entity_base
    {
        public long category { get; set; }
        public string name { get; set; }
        public long type { get; set; }
        public string options { get; set; }
        public long itemcount { get; set; }
    }
}