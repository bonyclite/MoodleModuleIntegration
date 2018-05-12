namespace Moodle3KL.Domain
{
    public class mdl_message : mdl_entity_base {
        public long useridfrom { get; set; }
        public long useridto { get; set; }
        public string subject { get; set; }
        public string fullmessage { get; set; }
        public short? fullmessageformat { get; set; }
        public string fullmessagehtml { get; set; }
        public string smallmessage { get; set; }
        public short? notification { get; set; }
        public string contexturl { get; set; }
        public string contexturlname { get; set; }
        public long timecreated { get; set; }
        public long timeuserfromdeleted { get; set; }
        public long timeusertodeleted { get; set; }
    }
}