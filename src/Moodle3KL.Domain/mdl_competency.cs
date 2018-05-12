namespace Moodle3KL.Domain
{
    public class mdl_competency : mdl_entity_base
    {
        public string shortname { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public string idnumber { get; set; }
        public long competencyframeworkid { get; set; }
        public long parentid { get; set; }
        public string path { get; set; }
        public long sortorder { get; set; }
        public string ruletype { get; set; }
        public short ruleoutcome { get; set; }
        public string ruleconfig { get; set; }
        public long? scaleid { get; set; }
        public string scaleconfiguration { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? usermodified { get; set; }
    }
}