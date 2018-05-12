namespace Moodle3KL.Domain
{
    public class mdl_user_private_key : mdl_entity_base {
        public string script { get; set; }
        public string value { get; set; }
        public long userid { get; set; }
        public long? instance { get; set; }
        public string iprestriction { get; set; }
        public long? validuntil { get; set; }
        public long? timecreated { get; set; }
    }
}