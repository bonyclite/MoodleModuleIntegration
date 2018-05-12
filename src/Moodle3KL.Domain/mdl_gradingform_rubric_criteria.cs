namespace Moodle3KL.Domain
{
    public class mdl_gradingform_rubric_criteria : mdl_entity_base
    {
        public long definitionid { get; set; }
        public long sortorder { get; set; }
        public string description { get; set; }
        public short? descriptionformat { get; set; }
    }
}