namespace Moodle3KL.Domain
{
    public class mdl_scorm_seq_rulecond
    {
        public long id { get; set; }
        public long scoid { get; set; }
        public long ruleconditionsid { get; set; }
        public string refrencedobjective { get; set; }
        public double measurethreshold { get; set; }
        public string @operator { get; set; }
        public string cond { get; set; }
    }
}