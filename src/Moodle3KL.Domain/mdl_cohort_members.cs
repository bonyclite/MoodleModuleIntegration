namespace Moodle3KL.Domain
{
    public class mdl_cohort_members : mdl_entity_base
    {
        public long cohortid { get; set; }
        public long userid { get; set; }
        public long timeadded { get; set; }
    }
}