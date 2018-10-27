namespace Moodle3KL.Domain
{
    public class mdl_wiziq : mdl_entity_base
    {
        public long course { get; set; }
        public long? insescod { get; set; }
        public long? class_id { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long wiziq_datetime { get; set; }
        public string class_timezone { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long duration { get; set; }
        public string vc_language { get; set; }
        public long? recording { get; set; }
        public long presenter_id { get; set; }
        public long? lasteditorid { get; set; }
        public string class_status { get; set; }
        public string recording_link { get; set; }
        public string view_recording_link { get; set; }
        public long? recording_link_status { get; set; }
    }
}