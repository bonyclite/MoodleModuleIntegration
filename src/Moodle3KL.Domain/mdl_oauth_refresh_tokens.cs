namespace Moodle3KL.Domain
{
    public class mdl_oauth_refresh_tokens : mdl_entity_base {
        public string refresh_token { get; set; }
        public string client_id { get; set; }
        public long? user_id { get; set; }
        public long expires { get; set; }
        public string scope { get; set; }
    }
}