namespace Moodle3KL.Domain
{
    public class mdl_mnet_sso_access_control : mdl_entity_base
    {
        public string username { get; set; }
        public long mnet_host_id { get; set; }
        public string accessctrl { get; set; }
    }
}