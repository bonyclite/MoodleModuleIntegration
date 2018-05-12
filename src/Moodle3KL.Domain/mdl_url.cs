namespace Moodle3KL.Domain
{
    public class mdl_url : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string externalurl { get; set; }
        public short display { get; set; }
        public string displayoptions { get; set; }
        public string parameters { get; set; }
        public long timemodified { get; set; }
    }
}