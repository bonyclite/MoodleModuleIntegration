namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_aclwarrantagents
    {
        public long id { get; set; }
        public long departmentid { get; set; }
        public long? personid { get; set; }
        public string baseptype { get; set; }
        public string basepcode { get; set; }
        public string basetype { get; set; }
        public long baseid { get; set; }
        public long aclwarrantid { get; set; }
        public long datecreate { get; set; }
        public long begindate { get; set; }
        public long duration { get; set; }
        public string status { get; set; }
        public short isdelegatable { get; set; }
    }
}