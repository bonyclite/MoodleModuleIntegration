namespace Moodle3KL.Domain
{
    public class mdl_profiling : mdl_entity_base {
        public string runid { get; set; }
        public string url { get; set; }
        public string data { get; set; }
        public long totalexecutiontime { get; set; }
        public long totalcputime { get; set; }
        public long totalcalls { get; set; }
        public long totalmemory { get; set; }
        public short runreference { get; set; }
        public string runcomment { get; set; }
        public long timecreated { get; set; }
    }
}