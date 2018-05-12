namespace Moodle3KL.Domain
{
    public class mdl_grading_areas
    {
        public long id { get; set; }
        public long contextid { get; set; }
        public string component { get; set; }
        public string areaname { get; set; }
        public string activemethod { get; set; }
    }
}