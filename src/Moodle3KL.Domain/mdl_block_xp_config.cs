namespace Moodle3KL.Domain
{
    public class mdl_block_xp_config : mdl_entity_base {
        public long courseid { get; set; }
        public short enabled { get; set; }
        public short enablelog { get; set; }
        public long keeplogs { get; set; }
        public long levels { get; set; }
        public long lastlogpurge { get; set; }
        public short enableladder { get; set; }
        public short enableinfos { get; set; }
        public string levelsdata { get; set; }
        public short enablelevelupnotif { get; set; }
        public short enablecustomlevelbadges { get; set; }
        public long maxactionspertime { get; set; }
        public long timeformaxactions { get; set; }
        public long timebetweensameactions { get; set; }
        public short identitymode { get; set; }
        public short rankmode { get; set; }
        public short neighbours { get; set; }
    }
}