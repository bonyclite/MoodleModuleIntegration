namespace Moodle3KL.Domain
{
    public class mdl_repository_instances : mdl_entity_base {
        public string name { get; set; }
        public long typeid { get; set; }
        public long userid { get; set; }
        public long contextid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public long? timecreated { get; set; }
        public long? timemodified { get; set; }
        public short @readonly { get; set; }
    }
}