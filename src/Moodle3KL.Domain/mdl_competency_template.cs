namespace Moodle3KL.Domain
{
    public class mdl_competency_template
    {
        public long id { get; set; }
        public string shortname { get; set; }
        public long contextid { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public short visible { get; set; }
        public long? duedate { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? usermodified { get; set; }
    }
}