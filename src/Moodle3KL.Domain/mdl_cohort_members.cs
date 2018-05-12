namespace Moodle3KL.Domain
{
    public class mdl_cohort_members
    {
        public long id { get; set; }
        public long cohortid { get; set; }
        public long userid { get; set; }
        public long timeadded { get; set; }
    }
}