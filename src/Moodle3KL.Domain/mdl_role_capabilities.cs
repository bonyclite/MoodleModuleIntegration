namespace Moodle3KL.Domain
{
    public class mdl_role_capabilities : mdl_entity_base
    {
        public long contextid { get; set; }
        public long roleid { get; set; }
        public string capability { get; set; }
        public long permission { get; set; }
        public long timemodified { get; set; }
        public long modifierid { get; set; }
    }
}