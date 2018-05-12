namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_positions : mdl_entity_base {
        public string name { get; set; }
        public string code { get; set; }
        public long? departmentid { get; set; }
        public string status { get; set; }
    }
}