namespace Moodle3KL.Domain
{
    public class mdl_course_completion_crit_compl : mdl_entity_base
    {
        public long userid { get; set; }
        public long course { get; set; }
        public long criteriaid { get; set; }
        public decimal? gradefinal { get; set; }
        public long? unenroled { get; set; }
        public long? timecompleted { get; set; }
    }
}