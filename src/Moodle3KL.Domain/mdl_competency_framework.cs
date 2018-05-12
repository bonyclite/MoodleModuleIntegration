namespace Moodle3KL.Domain
{
    public class mdl_competency_framework : mdl_entity_base
    {
        public string shortname { get; set; }
        public long contextid { get; set; }
        public string idnumber { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long? scaleid { get; set; }
        public string scaleconfiguration { get; set; }
        public short visible { get; set; }
        public string taxonomies { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? usermodified { get; set; }
    }
}