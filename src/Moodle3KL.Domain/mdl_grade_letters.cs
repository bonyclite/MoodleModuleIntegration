namespace Moodle3KL.Domain
{
    public class mdl_grade_letters : mdl_entity_base
    {
        public long contextid { get; set; }
        public decimal lowerboundary { get; set; }
        public string letter { get; set; }
    }
}