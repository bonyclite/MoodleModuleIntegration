namespace Moodle3KL.Domain
{
    public class mdl_competency_plancomp : mdl_entity_base {
        public long planid { get; set; }
        public long competencyid { get; set; }
        public long? sortorder { get; set; }
        public long timecreated { get; set; }
        public long? timemodified { get; set; }
        public long usermodified { get; set; }
    }
}