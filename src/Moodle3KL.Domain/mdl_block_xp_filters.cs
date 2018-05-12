namespace Moodle3KL.Domain
{
    public class mdl_block_xp_filters : mdl_entity_base
    {
        public long courseid { get; set; }
        public string ruledata { get; set; }
        public long points { get; set; }
        public long sortorder { get; set; }
    }
}