namespace Moodle3KL.Domain
{
    public class mdl_oauth_authorization_codes : mdl_entity_base {
        public string authorization_code { get; set; }
        public string client_id { get; set; }
        public long? user_id { get; set; }
        public string redirect_uri { get; set; }
        public long expires { get; set; }
        public string scope { get; set; }
        public string id_token { get; set; }
    }
}