namespace Moodle3KL.Domain
{
    public class mdl_forum_posts : mdl_entity_base {
        public long discussion { get; set; }
        public long parent { get; set; }
        public long userid { get; set; }
        public long created { get; set; }
        public long modified { get; set; }
        public short mailed { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public short messageformat { get; set; }
        public short messagetrust { get; set; }
        public string attachment { get; set; }
        public short totalscore { get; set; }
        public long mailnow { get; set; }
    }
}