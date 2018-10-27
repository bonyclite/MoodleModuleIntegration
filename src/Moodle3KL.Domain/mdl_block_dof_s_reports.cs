namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_reports : mdl_entity_base
    {
        public string plugintype { get; set; }
        public string plugincode { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public long? personid { get; set; }
        public long? requestdate { get; set; }
        public long? completedate { get; set; }
        public long? crondate { get; set; }
        public string status { get; set; }
        public long? departmentid { get; set; }
        public long? objectid { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public string requestdata { get; set; }
        public string filepath { get; set; }
    }
}