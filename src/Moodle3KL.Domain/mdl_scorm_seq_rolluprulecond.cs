namespace Moodle3KL.Domain
{
    public class mdl_scorm_seq_rolluprulecond : mdl_entity_base {
        public long scoid { get; set; }
        public long rollupruleid { get; set; }
        public string @operator { get; set; }
        public string cond { get; set; }
    }
}