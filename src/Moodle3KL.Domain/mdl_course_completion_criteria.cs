namespace Moodle3KL.Domain
{
    public class mdl_course_completion_criteria : mdl_entity_base
    {
        public long course { get; set; }
        public long criteriatype { get; set; }
        public string module { get; set; }
        public long? moduleinstance { get; set; }
        public long? courseinstance { get; set; }
        public long? enrolperiod { get; set; }
        public long? timeend { get; set; }
        public decimal? gradepass { get; set; }
        public long? role { get; set; }
    }
}