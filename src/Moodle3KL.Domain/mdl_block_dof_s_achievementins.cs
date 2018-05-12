namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_achievementins : mdl_entity_base
    {
        public long achievementid { get; set; }
        public long userid { get; set; }
        public long? moderatorid { get; set; }
        public long timecreated { get; set; }
        public long timechecked { get; set; }
        public double? userpoints { get; set; }
        public string data { get; set; }
        public string status { get; set; }
    }
}