namespace Moodle3KL.Domain
{
    public class mdl_gradingform_guide_criteria : mdl_entity_base
    {
        public long definitionid { get; set; }
        public long sortorder { get; set; }
        public string shortname { get; set; }
        public string description { get; set; }
        public short? descriptionformat { get; set; }
        public string descriptionmarkers { get; set; }
        public short? descriptionmarkersformat { get; set; }
        public decimal maxscore { get; set; }
    }
}