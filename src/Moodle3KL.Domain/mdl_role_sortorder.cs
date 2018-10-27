namespace Moodle3KL.Domain
{
    public class mdl_role_sortorder : mdl_entity_base
    {
        public long userid { get; set; }
        public long roleid { get; set; }
        public long contextid { get; set; }
        public long sortoder { get; set; }
    }
}