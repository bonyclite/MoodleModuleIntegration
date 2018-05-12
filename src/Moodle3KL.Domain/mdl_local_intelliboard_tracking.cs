namespace Moodle3KL.Domain
{
    public class mdl_local_intelliboard_tracking : mdl_entity_base {
        public long? userid { get; set; }
        public long? courseid { get; set; }
        public string page { get; set; }
        public long? param { get; set; }
        public long? visits { get; set; }
        public long? timespend { get; set; }
        public long? firstaccess { get; set; }
        public long? lastaccess { get; set; }
        public string useragent { get; set; }
        public string useros { get; set; }
        public string userlang { get; set; }
        public string userip { get; set; }
    }
}