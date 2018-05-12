namespace Moodle3KL.Domain
{
    public class mdl_lti_submission
    {
        public long id { get; set; }
        public long ltiid { get; set; }
        public long userid { get; set; }
        public long datesubmitted { get; set; }
        public long dateupdated { get; set; }
        public decimal gradepercent { get; set; }
        public decimal originalgrade { get; set; }
        public long launchid { get; set; }
        public short state { get; set; }
    }
}