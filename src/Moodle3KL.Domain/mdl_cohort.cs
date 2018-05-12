namespace Moodle3KL.Domain
{
    public class mdl_cohort
    {
        public long id { get; set; }
        public long contextid { get; set; }
        public string name { get; set; }
        public string idnumber { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public short visible { get; set; }
        public string component { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}