namespace Moodle3KL.Domain
{
    public class mdl_registration_hubs : mdl_entity_base
    {
        public string token { get; set; }
        public string hubname { get; set; }
        public string huburl { get; set; }
        public short confirmed { get; set; }
        public string secret { get; set; }
        public long timemodified { get; set; }
    }
}