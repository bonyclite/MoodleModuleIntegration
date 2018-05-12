namespace Moodle3KL.Domain
{
    public class mdl_format_grid_summary : mdl_entity_base {
        public short showsummary { get; set; }
        public long courseid { get; set; }
    }
}