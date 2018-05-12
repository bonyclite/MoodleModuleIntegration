namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_eagreements
    {
        public long id { get; set; }
        public long? personid { get; set; }
        public string num { get; set; }
        public string numpass { get; set; }
        public long? date { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
        public string notice { get; set; }
        public long? adddate { get; set; }
    }
}