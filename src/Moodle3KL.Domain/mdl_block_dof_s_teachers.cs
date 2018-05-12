namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_teachers
    {
        public long id { get; set; }
        public long? appointmentid { get; set; }
        public long? programmitemid { get; set; }
        public long? departmentid { get; set; }
        public decimal? worktime { get; set; }
        public string status { get; set; }
    }
}