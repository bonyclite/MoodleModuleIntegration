namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_taglinks
    {
        public long id { get; set; }
        public long tagid { get; set; }
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public long objectid { get; set; }
        public string sortname { get; set; }
        public long departmentid { get; set; }
        public string infotext { get; set; }
        public string infoserial { get; set; }
        public long date { get; set; }
        public long updatemark { get; set; }
        public string status { get; set; }
    }
}