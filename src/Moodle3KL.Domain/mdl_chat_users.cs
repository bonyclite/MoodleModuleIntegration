namespace Moodle3KL.Domain
{
    public class mdl_chat_users : mdl_entity_base {
        public long chatid { get; set; }
        public long userid { get; set; }
        public long groupid { get; set; }
        public string version { get; set; }
        public string ip { get; set; }
        public long firstping { get; set; }
        public long lastping { get; set; }
        public long lastmessageping { get; set; }
        public string sid { get; set; }
        public long course { get; set; }
        public string lang { get; set; }
    }
}