namespace Moodle3KL.Domain
{
    public class mdl_enrol_lti_users : mdl_entity_base
    {
        public long userid { get; set; }
        public long toolid { get; set; }
        public string serviceurl { get; set; }
        public string sourceid { get; set; }
        public string consumerkey { get; set; }
        public string consumersecret { get; set; }
        public string membershipsurl { get; set; }
        public string membershipsid { get; set; }
        public decimal? lastgrade { get; set; }
        public long? lastaccess { get; set; }
        public long? timecreated { get; set; }
    }
}