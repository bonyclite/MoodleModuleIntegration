namespace Moodle3KL.Domain
{
    public class mdl_backup_logs
    {
        public long id { get; set; }
        public string backupid { get; set; }
        public short loglevel { get; set; }
        public string message { get; set; }
        public long timecreated { get; set; }
    }
}