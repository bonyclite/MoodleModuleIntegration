namespace Moodle3KL.Domain
{
    public class mdl_badge_criteria_param : mdl_entity_base {
        public long critid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}