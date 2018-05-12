namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_orders
    {
        public long id { get; set; }
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public string pluginversion { get; set; }
        public string code { get; set; }
        public string num { get; set; }
        public long? departmentid { get; set; }
        public long? ownerid { get; set; }
        public long? signerid { get; set; }
        public long? date { get; set; }
        public long? signdate { get; set; }
        public long? exdate { get; set; }
        public long? crondate { get; set; }
        public long? changedate { get; set; }
        public string status { get; set; }
        public string sdata { get; set; }
        public string signature { get; set; }
        public string notes { get; set; }
    }
}