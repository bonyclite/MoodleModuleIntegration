namespace Moodle3KL.Domain
{
    public class mdl_role_context_levels : mdl_entity_base
    {
        public long roleid { get; set; }
        public long contextlevel { get; set; }
    }
}