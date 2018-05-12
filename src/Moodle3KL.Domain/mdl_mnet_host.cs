namespace Moodle3KL.Domain
{
    public class mdl_mnet_host : mdl_entity_base
    {
        public short deleted { get; set; }
        public string wwwroot { get; set; }
        public string ip_address { get; set; }
        public string name { get; set; }
        public string public_key { get; set; }
        public long public_key_expires { get; set; }
        public short transport { get; set; }
        public int portno { get; set; }
        public long last_connect_time { get; set; }
        public long last_log_id { get; set; }
        public short force_theme { get; set; }
        public string theme { get; set; }
        public long applicationid { get; set; }
        public short sslverification { get; set; }
    }
}