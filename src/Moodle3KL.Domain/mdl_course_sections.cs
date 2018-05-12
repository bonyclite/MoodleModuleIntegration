namespace Moodle3KL.Domain
{
    public class mdl_course_sections
    {
        public long id { get; set; }
        public long course { get; set; }
        public long section { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public short summaryformat { get; set; }
        public string sequence { get; set; }
        public short visible { get; set; }
        public string availability { get; set; }
    }
}