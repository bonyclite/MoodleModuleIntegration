namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_plansections : mdl_entity_base
    {
        public long? linkid { get; set; }
        public string linktype { get; set; }
        public string name { get; set; }
        public string status { get; set; }
    }
}