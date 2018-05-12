namespace Moodle3KL.Domain
{
    public class mdl_log_queries
    {
        public long id { get; set; }
        public int qtype { get; set; }
        public string sqltext { get; set; }
        public string sqlparams { get; set; }
        public int error { get; set; }
        public string info { get; set; }
        public string backtrace { get; set; }
        public decimal exectime { get; set; }
        public long timelogged { get; set; }
    }
}