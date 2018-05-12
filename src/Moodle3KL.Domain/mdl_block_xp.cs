namespace Moodle3KL.Domain
{
    public class mdl_block_xp : mdl_entity_base
    {
        public long courseid { get; set; }
        public long userid { get; set; }
        public long xp { get; set; }
        public long? lvl { get; set; }
    }
}