namespace Moodle3KL.Domain
{
    public class mdl_competency_relatedcomp : mdl_entity_base
    {
        public long competencyid { get; set; }
        public long relatedcompetencyid { get; set; }
        public long timecreated { get; set; }
        public long? timemodified { get; set; }
        public long usermodified { get; set; }
    }
}