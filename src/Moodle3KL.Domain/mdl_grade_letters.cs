namespace Moodle3KL.Domain
{
    public class mdl_grade_letters
    {
        public long id { get; set; }
        public long contextid { get; set; }
        public decimal lowerboundary { get; set; }
        public string letter { get; set; }
    }
}