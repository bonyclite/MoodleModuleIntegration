namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_accentryes
    {
        public long id { get; set; }
        public long fromid { get; set; }
        public long toid { get; set; }
        public double amount { get; set; }
        public long orderid { get; set; }
        public int createdate { get; set; }
        public int date { get; set; }
        public string extentryopts { get; set; }
        public string extentryoptshash { get; set; }
        public string about { get; set; }
        public string status { get; set; }
    }
}