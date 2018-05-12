namespace Moodle3KL.Domain
{
    public class mdl_assignfeedback_file : mdl_entity_base {
        public long assignment { get; set; }
        public long grade { get; set; }
        public long numfiles { get; set; }
    }
}