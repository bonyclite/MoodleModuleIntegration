namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_achievements : mdl_entity_base {
        public long catid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public long sortorder { get; set; }
        public long createdate { get; set; }
        public long changedate { get; set; }
        public double? points { get; set; }
        public string data { get; set; }
        public string status { get; set; }
    }
}