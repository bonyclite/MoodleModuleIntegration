namespace Moodle3KL.Domain
{
    public class mdl_oauth_scopes : mdl_entity_base {
        public string scope { get; set; }
        public short? is_default { get; set; }
    }
}