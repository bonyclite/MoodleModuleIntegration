namespace Moodle3KL.Domain
{
    public class mdl_survey : mdl_entity_base {
        public long course { get; set; }
        public long template { get; set; }
        public int days { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string questions { get; set; }
    }
}