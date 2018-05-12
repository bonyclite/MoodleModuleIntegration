namespace Moodle3KL.Domain
{
    public class mdl_grading_instances : mdl_entity_base
    {
        public long definitionid { get; set; }
        public long raterid { get; set; }
        public long? itemid { get; set; }
        public decimal? rawgrade { get; set; }
        public long status { get; set; }
        public string feedback { get; set; }
        public short? feedbackformat { get; set; }
        public long timemodified { get; set; }
    }
}