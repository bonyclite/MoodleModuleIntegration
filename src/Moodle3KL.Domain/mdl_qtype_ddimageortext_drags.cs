namespace Moodle3KL.Domain
{
    public class mdl_qtype_ddimageortext_drags : mdl_entity_base {
        public long questionid { get; set; }
        public long no { get; set; }
        public long draggroup { get; set; }
        public short infinite { get; set; }
        public string label { get; set; }
    }
}