namespace Moodle3KL.Domain
{
    public class mdl_message_working : mdl_entity_base {
        public long unreadmessageid { get; set; }
        public long processorid { get; set; }
    }
}