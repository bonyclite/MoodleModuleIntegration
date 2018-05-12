namespace Moodle3KL.Domain
{
    public class mdl_feedback_valuetmp
    {
        public long id { get; set; }
        public long course_id { get; set; }
        public long item { get; set; }
        public long completed { get; set; }
        public long tmp_completed { get; set; }
        public string value { get; set; }
    }
}