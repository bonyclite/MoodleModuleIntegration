namespace Moodle3KL.Domain
{
    public class mdl_recordingsbn : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short ui_html { get; set; }
        public short include_deleted_activities { get; set; }
    }
}