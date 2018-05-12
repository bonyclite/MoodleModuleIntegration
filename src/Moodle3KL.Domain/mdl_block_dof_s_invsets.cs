namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_invsets
    {
        public long id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public long? invcategoryid { get; set; }
        public long departmentid { get; set; }
        public long? personid { get; set; }
        public string status { get; set; }
        public string note { get; set; }
    }
}