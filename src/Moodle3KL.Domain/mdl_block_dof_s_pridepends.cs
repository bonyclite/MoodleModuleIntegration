namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_pridepends : mdl_entity_base {
        public long programmitemid { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }
}