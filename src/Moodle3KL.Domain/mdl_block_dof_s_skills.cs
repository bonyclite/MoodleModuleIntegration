namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_skills : mdl_entity_base
    {
        public string name { get; set; }
        public double complexity { get; set; }
        public long? parentid { get; set; }
        public short self { get; set; }
        public string path { get; set; }
        public string status { get; set; }
    }
}