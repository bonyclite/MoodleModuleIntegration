namespace Moodle3KL.Domain
{
    public class mdl_mnet_log : mdl_entity_base
    {
        public long hostid { get; set; }
        public long remoteid { get; set; }
        public long time { get; set; }
        public long userid { get; set; }
        public string ip { get; set; }
        public long course { get; set; }
        public string coursename { get; set; }
        public string module { get; set; }
        public long cmid { get; set; }
        public string action { get; set; }
        public string url { get; set; }
        public string info { get; set; }
    }
}