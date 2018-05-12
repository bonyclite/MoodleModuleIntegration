namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_config
    {
        public long id { get; set; }
        public long departmentid { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public short noextend { get; set; }
        public long? personid { get; set; }
    }
}