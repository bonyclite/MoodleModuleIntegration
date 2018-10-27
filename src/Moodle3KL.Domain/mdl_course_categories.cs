namespace Moodle3KL.Domain
{
    public class mdl_course_categories : mdl_entity_base
    {
        public string name { get; set; }
        public string idnumber { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long parent { get; set; }
        public long sortorder { get; set; }
        public long coursecount { get; set; }
        public short visible { get; set; }
        public short visibleold { get; set; }
        public long timemodified { get; set; }
        public long depth { get; set; }
        public string path { get; set; }
        public string theme { get; set; }
    }
}