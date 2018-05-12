namespace Moodle3KL.Domain
{
    public class mdl_competency_modulecomp
    {
        public long id { get; set; }
        public long cmid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
        public long sortorder { get; set; }
        public long competencyid { get; set; }
        public short ruleoutcome { get; set; }
    }
}