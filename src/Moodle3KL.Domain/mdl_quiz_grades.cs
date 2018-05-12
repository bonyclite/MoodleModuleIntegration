namespace Moodle3KL.Domain
{
    public class mdl_quiz_grades
    {
        public long id { get; set; }
        public long quiz { get; set; }
        public long userid { get; set; }
        public decimal grade { get; set; }
        public long timemodified { get; set; }
    }
}