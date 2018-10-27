namespace Moodle3KL.Domain
{
    public class mdl_mnet_application : mdl_entity_base
    {
        public string name { get; set; }
        public string display_name { get; set; }
        public string xmlrpc_server_url { get; set; }
        public string sso_land_url { get; set; }
        public string sso_jump_url { get; set; }
    }
}