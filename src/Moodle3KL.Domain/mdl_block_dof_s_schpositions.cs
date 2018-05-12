namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_schpositions : mdl_entity_base
    {
        public long? positionid { get; set; }
        public decimal? worktime { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
    }
}