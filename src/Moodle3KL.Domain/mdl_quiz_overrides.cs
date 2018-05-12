namespace Moodle3KL.Domain
{
    public class mdl_quiz_overrides : mdl_entity_base {
        public long quiz { get; set; }
        public long? groupid { get; set; }
        public long? userid { get; set; }
        public long? timeopen { get; set; }
        public long? timeclose { get; set; }
        public long? timelimit { get; set; }
        public int? attempts { get; set; }
        public string password { get; set; }
    }
}