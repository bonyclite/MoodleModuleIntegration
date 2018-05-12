namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_statushistory
    {
        public long id { get; set; }
        public string status { get; set; }
        public string prevstatus { get; set; }
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public long? muserid { get; set; }
        public long? objectid { get; set; }
        public long? statusdate { get; set; }
        public string notes { get; set; }
        public string opt { get; set; }
        public long? orderid { get; set; }
    }
}