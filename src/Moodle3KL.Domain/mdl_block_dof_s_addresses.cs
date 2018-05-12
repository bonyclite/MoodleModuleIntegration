namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_addresses
    {
        public long id { get; set; }
        public short? type { get; set; }
        public string postalcode { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string county { get; set; }
        public string city { get; set; }
        public string streetname { get; set; }
        public string streettype { get; set; }
        public string number { get; set; }
        public string gate { get; set; }
        public string floor { get; set; }
        public string apartment { get; set; }
        public decimal? latitude { get; set; }
        public decimal? longitude { get; set; }
        public string status { get; set; }
    }
}