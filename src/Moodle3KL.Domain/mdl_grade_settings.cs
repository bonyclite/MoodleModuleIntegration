namespace Moodle3KL.Domain
{
    public class mdl_grade_settings
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}