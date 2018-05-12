namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_accounts : mdl_entity_base
    {
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public string code { get; set; }
        public long objectid { get; set; }
        public string type { get; set; }
        public int createdate { get; set; }
        public string md5code { get; set; }
        public string name { get; set; }
        public string status { get; set; }
    }
}