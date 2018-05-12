namespace Moodle3KL.Domain
{
    public class mdl_oauth_scopes
    {
        public long id { get; set; }
        public string scope { get; set; }
        public short? is_default { get; set; }
    }
}