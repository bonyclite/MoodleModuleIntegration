namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_editpdf_quick : mdl_entity_base {
        public long userid { get; set; }
        public string rawtext { get; set; }
        public long width { get; set; }
        public string colour { get; set; }
    }
}