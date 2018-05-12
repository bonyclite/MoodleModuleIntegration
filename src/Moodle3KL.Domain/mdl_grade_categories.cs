namespace Moodle3KL.Domain
{
    public class mdl_grade_categories : mdl_entity_base {
        public long courseid { get; set; }
        public long? parent { get; set; }
        public long depth { get; set; }
        public string path { get; set; }
        public string fullname { get; set; }
        public long aggregation { get; set; }
        public long keephigh { get; set; }
        public long droplow { get; set; }
        public short aggregateonlygraded { get; set; }
        public short aggregateoutcomes { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short hidden { get; set; }
    }
}