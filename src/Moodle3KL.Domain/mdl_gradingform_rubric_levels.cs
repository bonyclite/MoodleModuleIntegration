namespace Moodle3KL.Domain
{
    public class mdl_gradingform_rubric_levels : mdl_entity_base
    {
        public long criterionid { get; set; }
        public decimal score { get; set; }
        public string definition { get; set; }
        public long? definitionformat { get; set; }
    }
}