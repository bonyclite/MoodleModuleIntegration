namespace Moodle3KL.Domain
{
    public class mdl_course_completion_aggr_methd : mdl_entity_base {
        public long course { get; set; }
        public long? criteriatype { get; set; }
        public short method { get; set; }
        public decimal? value { get; set; }
    }
}