namespace Moodle3KL.Domain
{
    public class mdl_quiz_grades : mdl_entity_base {
        public long quiz { get; set; }
        public long userid { get; set; }
        public decimal grade { get; set; }
        public long timemodified { get; set; }
    }
}