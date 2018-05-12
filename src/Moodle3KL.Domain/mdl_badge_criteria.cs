namespace Moodle3KL.Domain
{
    public class mdl_badge_criteria : mdl_entity_base {
        public long badgeid { get; set; }
        public long? criteriatype { get; set; }
        public short method { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
    }
}