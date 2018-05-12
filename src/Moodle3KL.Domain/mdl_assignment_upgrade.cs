namespace Moodle3KL.Domain
{
    public class mdl_assignment_upgrade : mdl_entity_base
    {
        public long oldcmid { get; set; }
        public long oldinstance { get; set; }
        public long newcmid { get; set; }
        public long newinstance { get; set; }
        public long timecreated { get; set; }
    }
}