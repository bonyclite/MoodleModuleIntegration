namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_plans : mdl_entity_base {
        public long? linkid { get; set; }
        public string linktype { get; set; }
        public long? parentid { get; set; }
        public string name { get; set; }
        public long? date { get; set; }
        public long? reldate { get; set; }
        public long? reldldate { get; set; }
        public string scale { get; set; }
        public string type { get; set; }
        public string typesync { get; set; }
        public long? mdlinstance { get; set; }
        public string status { get; set; }
        public string homework { get; set; }
        public long? homeworkhours { get; set; }
        public short? directmap { get; set; }
        public long? number { get; set; }
        public long? datetheme { get; set; }
        public long? plansectionsid { get; set; }
        public string note { get; set; }
    }
}