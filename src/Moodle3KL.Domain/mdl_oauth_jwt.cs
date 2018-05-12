namespace Moodle3KL.Domain
{
    public class mdl_oauth_jwt : mdl_entity_base
    {
        public string client_id { get; set; }
        public string subject { get; set; }
        public string public_key { get; set; }
    }
}