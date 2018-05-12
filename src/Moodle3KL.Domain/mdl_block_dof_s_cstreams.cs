namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_cstreams : mdl_entity_base
    {
        public long? ageid { get; set; }
        public long? programmitemid { get; set; }
        public long? teacherid { get; set; }
        public long? departmentid { get; set; }
        public long? appointmentid { get; set; }
        public long? mdlgroup { get; set; }
        public short? eduweeks { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public string status { get; set; }
        public long? hours { get; set; }
        public long? hoursweek { get; set; }
        public decimal? hoursweekinternally { get; set; }
        public string name { get; set; }
        public decimal? hoursweekdistance { get; set; }
        public string explanatory { get; set; }
        public long? lastgradesync { get; set; }
        public double salfactor { get; set; }
        public double substsalfactor { get; set; }
    }
}