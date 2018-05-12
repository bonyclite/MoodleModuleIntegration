namespace Moodle3KL.Domain
{
    public class mdl_assignsubmission_file : mdl_entity_base {
        public long assignment { get; set; }
        public long submission { get; set; }
        public long numfiles { get; set; }
    }
}