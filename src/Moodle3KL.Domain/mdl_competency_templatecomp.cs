namespace Moodle3KL.Domain
{
    public class mdl_competency_templatecomp : mdl_entity_base {
        public long templateid { get; set; }
        public long competencyid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
        public long? sortorder { get; set; }
    }
}