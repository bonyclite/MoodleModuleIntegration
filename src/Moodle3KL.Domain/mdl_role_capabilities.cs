namespace Moodle3KL.Domain
{
    public class mdl_role_capabilities
    {
        public long id { get; set; }
        public long contextid { get; set; }
        public long roleid { get; set; }
        public string capability { get; set; }
        public long permission { get; set; }
        public long timemodified { get; set; }
        public long modifierid { get; set; }
    }
}