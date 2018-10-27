namespace Moodle3KL.Domain
{
    public class mdl_hotpot_attempts : mdl_entity_base
    {
        public long hotpotid { get; set; }
        public long userid { get; set; }
        public long starttime { get; set; }
        public long endtime { get; set; }
        public int score { get; set; }
        public int penalties { get; set; }
        public int attempt { get; set; }
        public long timestart { get; set; }
        public long timefinish { get; set; }
        public short status { get; set; }
        public long clickreportid { get; set; }
        public long timemodified { get; set; }
    }
}