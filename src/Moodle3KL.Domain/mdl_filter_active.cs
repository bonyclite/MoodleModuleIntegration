namespace Moodle3KL.Domain
{
    public class mdl_filter_active : mdl_entity_base
    {
        public string filter { get; set; }
        public long contextid { get; set; }
        public short active { get; set; }
        public long sortorder { get; set; }
    }
}