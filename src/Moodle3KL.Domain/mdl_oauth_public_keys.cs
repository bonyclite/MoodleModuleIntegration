namespace Moodle3KL.Domain
{
    public class mdl_oauth_public_keys : mdl_entity_base
    {
        public string client_id { get; set; }
        public string public_key { get; set; }
        public string private_key { get; set; }
        public string encryption_algorithm { get; set; }
    }
}