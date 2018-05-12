namespace Moodle3KL.Domain
{
    public class mdl_tool_cohortroles : mdl_entity_base {
        public long cohortid { get; set; }
        public long roleid { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? usermodified { get; set; }
    }
}