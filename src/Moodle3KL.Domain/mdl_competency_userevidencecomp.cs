namespace Moodle3KL.Domain
{
    public class mdl_competency_userevidencecomp
    {
        public long id { get; set; }
        public long userevidenceid { get; set; }
        public long competencyid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
    }
}