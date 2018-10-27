namespace Moodle3KL.Domain
{
    public class mdl_badge_criteria_met : mdl_entity_base
    {
        public long? issuedid { get; set; }
        public long critid { get; set; }
        public long userid { get; set; }
        public long datemet { get; set; }
    }
}