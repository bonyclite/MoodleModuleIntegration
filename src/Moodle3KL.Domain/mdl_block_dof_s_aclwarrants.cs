namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_aclwarrants : mdl_entity_base
    {
        public string linkptype { get; set; }
        public string linkpcode { get; set; }
        public long linkid { get; set; }
        public string linktype { get; set; }
        public string code { get; set; }
        public long? parentid { get; set; }
        public string parenttype { get; set; }
        public short isdelegatable { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public long? ownerid { get; set; }
        public long? departmentid { get; set; }
    }
}