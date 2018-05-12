namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_appointments
    {
        public long id { get; set; }
        public long? eagreementid { get; set; }
        public long? schpositionid { get; set; }
        public string enumber { get; set; }
        public decimal? worktime { get; set; }
        public long? date { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
        public short? combination { get; set; }
    }
}