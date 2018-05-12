namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_achievementcats : mdl_entity_base {
        public string name { get; set; }
        public long parentid { get; set; }
        public long? departmentid { get; set; }
        public long sortorder { get; set; }
        public short affectrating { get; set; }
        public long createdate { get; set; }
        public string status { get; set; }
    }
}