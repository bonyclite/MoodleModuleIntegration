namespace Moodle3KL.Domain
{
    public class mdl_backup_courses : mdl_entity_base {
        public long courseid { get; set; }
        public long laststarttime { get; set; }
        public long lastendtime { get; set; }
        public string laststatus { get; set; }
        public long nextstarttime { get; set; }
    }
}