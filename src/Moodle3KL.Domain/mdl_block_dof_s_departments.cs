namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_departments : mdl_entity_base
    {
        public string name { get; set; }
        public string code { get; set; }
        public long? managerid { get; set; }
        public long leaddepid { get; set; }
        public long? addressid { get; set; }
        public string zone { get; set; }
        public string status { get; set; }
        public string path { get; set; }
        public long? depth { get; set; }
    }
}