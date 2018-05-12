namespace Moodle3KL.Domain
{
    public class mdl_competency_templatecohort
    {
        public long id { get; set; }
        public long templateid { get; set; }
        public long cohortid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
    }
}