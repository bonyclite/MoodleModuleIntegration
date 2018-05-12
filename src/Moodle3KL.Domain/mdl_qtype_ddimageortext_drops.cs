namespace Moodle3KL.Domain
{
    public class mdl_qtype_ddimageortext_drops : mdl_entity_base {
        public long questionid { get; set; }
        public long no { get; set; }
        public long xleft { get; set; }
        public long ytop { get; set; }
        public long choice { get; set; }
        public string label { get; set; }
    }
}