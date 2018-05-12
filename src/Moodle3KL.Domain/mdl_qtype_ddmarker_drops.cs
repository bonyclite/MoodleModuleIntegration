namespace Moodle3KL.Domain
{
    public class mdl_qtype_ddmarker_drops : mdl_entity_base {
        public long questionid { get; set; }
        public long no { get; set; }
        public string shape { get; set; }
        public string coords { get; set; }
        public long choice { get; set; }
    }
}