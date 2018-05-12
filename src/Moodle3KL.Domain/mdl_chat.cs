namespace Moodle3KL.Domain
{
    public class mdl_chat : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long keepdays { get; set; }
        public short studentlogs { get; set; }
        public long chattime { get; set; }
        public short schedule { get; set; }
        public long timemodified { get; set; }
    }
}