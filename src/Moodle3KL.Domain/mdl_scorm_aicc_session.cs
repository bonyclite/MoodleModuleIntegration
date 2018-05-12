namespace Moodle3KL.Domain
{
    public class mdl_scorm_aicc_session
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long scormid { get; set; }
        public string hacpsession { get; set; }
        public long? scoid { get; set; }
        public string scormmode { get; set; }
        public string scormstatus { get; set; }
        public long? attempt { get; set; }
        public string lessonstatus { get; set; }
        public string sessiontime { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}