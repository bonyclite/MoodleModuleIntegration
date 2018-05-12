namespace Moodle3KL.Domain
{
    public class mdl_quiz_attempts
    {
        public long id { get; set; }
        public long quiz { get; set; }
        public long userid { get; set; }
        public int attempt { get; set; }
        public long uniqueid { get; set; }
        public string layout { get; set; }
        public long currentpage { get; set; }
        public short preview { get; set; }
        public string state { get; set; }
        public long timestart { get; set; }
        public long timefinish { get; set; }
        public long timemodified { get; set; }
        public long? timecheckstate { get; set; }
        public decimal? sumgrades { get; set; }
    }
}