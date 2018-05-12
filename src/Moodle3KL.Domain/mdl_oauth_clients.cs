namespace Moodle3KL.Domain
{
    public class mdl_oauth_clients : mdl_entity_base {
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string redirect_uri { get; set; }
        public string grant_types { get; set; }
        public string scope { get; set; }
        public long? user_id { get; set; }
    }
}