namespace Moodle3KL.Domain
{
    public class mdl_question_datasets : mdl_entity_base {
        public long question { get; set; }
        public long datasetdefinition { get; set; }
    }
}