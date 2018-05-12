namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_ages
    {
        public long id { get; set; }
        public string name { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public short? eduweeks { get; set; }
        public long? departmentid { get; set; }
        public long? previousid { get; set; }
        public string status { get; set; }
        public int schdays { get; set; }
        public string schedudays { get; set; }
        public int schstartdaynum { get; set; }
    }
}