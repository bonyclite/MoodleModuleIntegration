namespace Moodle3KL.Domain
{
    public class mdl_mnet_host2service
    {
        public long id { get; set; }
        public long hostid { get; set; }
        public long serviceid { get; set; }
        public short publish { get; set; }
        public short subscribe { get; set; }
    }
}