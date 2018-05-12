namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_invitems : mdl_entity_base
    {
        public string name { get; set; }
        public string code { get; set; }
        public string serialnum { get; set; }
        public string type { get; set; }
        public long count { get; set; }
        public long? termofuse { get; set; }
        public long? dateentry { get; set; }
        public long? datewriteoff { get; set; }
        public long? invcategoryid { get; set; }
        public long departmentid { get; set; }
        public long? invsetid { get; set; }
        public long? setorderid { get; set; }
        public long? outorderid { get; set; }
        public string status { get; set; }
    }
}