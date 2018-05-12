namespace Moodle3KL.Domain
{
    public class mdl_user_devices : mdl_entity_base {
        public long userid { get; set; }
        public string appid { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string platform { get; set; }
        public string version { get; set; }
        public string pushid { get; set; }
        public string uuid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}