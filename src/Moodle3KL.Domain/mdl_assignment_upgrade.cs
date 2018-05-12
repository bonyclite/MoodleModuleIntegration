namespace Moodle3KL.Domain
{
    public class mdl_assignment_upgrade
    {
        public long id { get; set; }
        public long oldcmid { get; set; }
        public long oldinstance { get; set; }
        public long newcmid { get; set; }
        public long newinstance { get; set; }
        public long timecreated { get; set; }
    }
}