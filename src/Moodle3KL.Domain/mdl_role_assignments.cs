namespace Moodle3KL.Domain
{
    public class mdl_role_assignments : mdl_entity_base
    {
        public long roleid { get; set; }
        public long contextid { get; set; }
        public long userid { get; set; }
        public long timemodified { get; set; }
        public long modifierid { get; set; }
        public string component { get; set; }
        public long itemid { get; set; }
        public long sortorder { get; set; }
    }
}