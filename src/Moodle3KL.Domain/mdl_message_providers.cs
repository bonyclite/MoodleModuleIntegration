namespace Moodle3KL.Domain
{
    public class mdl_message_providers : mdl_entity_base {
        public string name { get; set; }
        public string component { get; set; }
        public string capability { get; set; }
    }
}