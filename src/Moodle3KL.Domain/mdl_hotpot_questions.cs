namespace Moodle3KL.Domain
{
    public class mdl_hotpot_questions : mdl_entity_base {
        public string name { get; set; }
        public short type { get; set; }
        public long text { get; set; }
        public long hotpotid { get; set; }
        public string md5key { get; set; }
    }
}