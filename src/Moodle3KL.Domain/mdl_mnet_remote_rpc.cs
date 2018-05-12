namespace Moodle3KL.Domain
{
    public class mdl_mnet_remote_rpc : mdl_entity_base
    {
        public string functionname { get; set; }
        public string xmlrpcpath { get; set; }
        public string plugintype { get; set; }
        public string pluginname { get; set; }
        public short enabled { get; set; }
    }
}