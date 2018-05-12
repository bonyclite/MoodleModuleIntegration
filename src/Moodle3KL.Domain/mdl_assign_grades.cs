namespace Moodle3KL.Domain
{
    public class mdl_assign_grades
    {
        public long id { get; set; }
        public long assignment { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long grader { get; set; }
        public decimal? grade { get; set; }
        public long attemptnumber { get; set; }
    }
}