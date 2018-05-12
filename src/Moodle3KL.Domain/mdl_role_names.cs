namespace Moodle3KL.Domain
{
    public class mdl_role_names : mdl_entity_base {
        public long roleid { get; set; }
        public long contextid { get; set; }
        public string name { get; set; }
    }
}