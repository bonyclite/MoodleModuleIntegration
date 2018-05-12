namespace Moodle3KL.Domain
{
    public class mdl_grade_outcomes_courses : mdl_entity_base
    {
        public long courseid { get; set; }
        public long outcomeid { get; set; }
    }
}