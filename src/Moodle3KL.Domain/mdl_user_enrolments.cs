namespace Moodle3KL.Domain
{
    public class mdl_user_enrolments : mdl_entity_base
    {
        public long status { get; set; }
        public long enrolid { get; set; }
        public long userid { get; set; }
        public long timestart { get; set; }
        public long timeend { get; set; }
        public long modifierid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}