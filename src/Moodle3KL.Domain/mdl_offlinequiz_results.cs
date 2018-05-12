namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_results : mdl_entity_base {
        public long offlinequizid { get; set; }
        public long offlinegroupid { get; set; }
        public long userid { get; set; }
        public decimal? sumgrades { get; set; }
        public long usageid { get; set; }
        public long teacherid { get; set; }
        public string attendant { get; set; }
        public string status { get; set; }
        public long timestart { get; set; }
        public long? timefinish { get; set; }
        public long timemodified { get; set; }
        public short? preview { get; set; }
    }
}