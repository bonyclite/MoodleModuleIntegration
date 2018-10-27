namespace Moodle3KL.Domain
{
    public class mdl_feedback : mdl_entity_base
    {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short anonymous { get; set; }
        public short email_notification { get; set; }
        public short multiple_submit { get; set; }
        public short autonumbering { get; set; }
        public string site_after_submit { get; set; }
        public string page_after_submit { get; set; }
        public short page_after_submitformat { get; set; }
        public short publish_stats { get; set; }
        public long timeopen { get; set; }
        public long timeclose { get; set; }
        public long timemodified { get; set; }
        public short completionsubmit { get; set; }
    }
}