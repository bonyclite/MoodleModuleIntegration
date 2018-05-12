namespace Moodle3KL.Domain
{
    public class mdl_post : mdl_entity_base {
        public string module { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public long groupid { get; set; }
        public long moduleid { get; set; }
        public long coursemoduleid { get; set; }
        public string subject { get; set; }
        public string summary { get; set; }
        public string content { get; set; }
        public string uniquehash { get; set; }
        public long rating { get; set; }
        public long format { get; set; }
        public short summaryformat { get; set; }
        public string attachment { get; set; }
        public string publishstate { get; set; }
        public long lastmodified { get; set; }
        public long created { get; set; }
        public long? usermodified { get; set; }
    }
}