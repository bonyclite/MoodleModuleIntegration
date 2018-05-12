namespace Moodle3KL.Domain
{
    public class mdl_course_published
    {
        public long id { get; set; }
        public string huburl { get; set; }
        public long courseid { get; set; }
        public long timepublished { get; set; }
        public short enrollable { get; set; }
        public long hubcourseid { get; set; }
        public short? status { get; set; }
        public long? timechecked { get; set; }
    }
}