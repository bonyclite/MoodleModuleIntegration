namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_synclogs : mdl_entity_base {
        public long syncid { get; set; }
        public long? executetime { get; set; }
        public string operation { get; set; }
        public string direct { get; set; }
        public string prevoperation { get; set; }
        public string error { get; set; }
        public string textlog { get; set; }
        public string optlog { get; set; }
    }
}