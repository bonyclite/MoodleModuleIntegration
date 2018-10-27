namespace Moodle3KL.Domain
{
    public class mdl_lesson_grades : mdl_entity_base
    {
        public long lessonid { get; set; }
        public long userid { get; set; }
        public double grade { get; set; }
        public short late { get; set; }
        public long completed { get; set; }
    }
}