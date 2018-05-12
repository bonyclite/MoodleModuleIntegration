namespace Moodle3KL.Domain
{
    public class mdl_assignment_submissions : mdl_entity_base {
        public long assignment { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long numfiles { get; set; }
        public string data1 { get; set; }
        public string data2 { get; set; }
        public long grade { get; set; }
        public string submissioncomment { get; set; }
        public short format { get; set; }
        public long teacher { get; set; }
        public long timemarked { get; set; }
        public short mailed { get; set; }
    }
}