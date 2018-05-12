namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_contracts
    {
        public long id { get; set; }
        public short? typeid { get; set; }
        public string num { get; set; }
        public string numpass { get; set; }
        public long date { get; set; }
        public long? sellerid { get; set; }
        public long? clientid { get; set; }
        public long? studentid { get; set; }
        public long adddate { get; set; }
        public string notes { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
        public string contractform { get; set; }
        public string organizationid { get; set; }
        public long? curatorid { get; set; }
        public long? enddate { get; set; }
        public long? metacontractid { get; set; }
    }
}