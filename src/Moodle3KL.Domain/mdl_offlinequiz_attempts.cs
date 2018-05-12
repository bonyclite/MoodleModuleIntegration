namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_attempts
    {
        public long id { get; set; }
        public long uniqueid { get; set; }
        public long offlinequiz { get; set; }
        public long groupid { get; set; }
        public long userid { get; set; }
        public int attempt { get; set; }
        public double sumgrades { get; set; }
        public long timestart { get; set; }
        public long timefinish { get; set; }
        public long timemodified { get; set; }
        public string layout { get; set; }
        public short sheet { get; set; }
        public short preview { get; set; }
    }
}