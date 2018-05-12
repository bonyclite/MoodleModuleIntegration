namespace Moodle3KL.Domain
{
    public class mdl_competency_evidence : mdl_entity_base {
        public long usercompetencyid { get; set; }
        public long contextid { get; set; }
        public short action { get; set; }
        public long? actionuserid { get; set; }
        public string descidentifier { get; set; }
        public string desccomponent { get; set; }
        public string desca { get; set; }
        public string url { get; set; }
        public long? grade { get; set; }
        public string note { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
    }
}