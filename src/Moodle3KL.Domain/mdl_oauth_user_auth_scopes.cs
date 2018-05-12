namespace Moodle3KL.Domain
{
    public class mdl_oauth_user_auth_scopes
    {
        public long id { get; set; }
        public string client_id { get; set; }
        public long user_id { get; set; }
        public string scope { get; set; }
    }
}