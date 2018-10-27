namespace Moodle3KL.Domain
{
    public class mdl_role_allow_override : mdl_entity_base
    {
        public long roleid { get; set; }
        public long allowoverride { get; set; }
    }
}