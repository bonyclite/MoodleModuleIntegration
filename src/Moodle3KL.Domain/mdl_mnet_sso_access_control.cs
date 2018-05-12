namespace Moodle3KL.Domain
{
    public class mdl_mnet_sso_access_control
    {
        public long id { get; set; }
        public string username { get; set; }
        public long mnet_host_id { get; set; }
        public string accessctrl { get; set; }
    }
}