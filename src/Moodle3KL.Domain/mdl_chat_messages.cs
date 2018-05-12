namespace Moodle3KL.Domain
{
    public class mdl_chat_messages
    {
        public long id { get; set; }
        public long chatid { get; set; }
        public long userid { get; set; }
        public long groupid { get; set; }
        public short system { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
    }
}