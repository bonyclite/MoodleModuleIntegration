namespace Moodle3KL.Domain
{
    public class mdl_backup_controllers : mdl_entity_base
    {
        public string backupid { get; set; }
        public string operation { get; set; }
        public string type { get; set; }
        public long itemid { get; set; }
        public string format { get; set; }
        public short interactive { get; set; }
        public short purpose { get; set; }
        public long userid { get; set; }
        public short status { get; set; }
        public short execution { get; set; }
        public long executiontime { get; set; }
        public string checksum { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string controller { get; set; }
    }
}