namespace Moodle3KL.Domain
{
    public class mdl_block_configurable_reports
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long ownerid { get; set; }
        public short visible { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string type { get; set; }
        public short? pagination { get; set; }
        public string components { get; set; }
        public string export { get; set; }
        public short? jsordering { get; set; }
        public short? global { get; set; }
        public long? lastexecutiontime { get; set; }
        public short cron { get; set; }
        public short? remote { get; set; }
    }
}