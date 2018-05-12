namespace Moodle3KL.Domain
{
    public class mdl_role_allow_switch : mdl_entity_base {
        public long roleid { get; set; }
        public long allowswitch { get; set; }
    }
}