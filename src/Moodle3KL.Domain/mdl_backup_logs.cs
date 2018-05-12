namespace Moodle3KL.Domain
{
    public class mdl_backup_logs : mdl_entity_base
    {
        public string backupid { get; set; }
        public short loglevel { get; set; }
        public string message { get; set; }
        public long timecreated { get; set; }
    }
}