namespace Moodle3KL.Domain
{
    public class mdl_competency_usercompplan : mdl_entity_base
    {
        public long userid { get; set; }
        public long competencyid { get; set; }
        public long planid { get; set; }
        public short? proficiency { get; set; }
        public long? grade { get; set; }
        public long? sortorder { get; set; }
        public long timecreated { get; set; }
        public long? timemodified { get; set; }
        public long usermodified { get; set; }
    }
}