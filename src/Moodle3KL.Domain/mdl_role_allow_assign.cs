namespace Moodle3KL.Domain
{
    public class mdl_role_allow_assign : mdl_entity_base
    {
        public long roleid { get; set; }
        public long allowassign { get; set; }
    }
}