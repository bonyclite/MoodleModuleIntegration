namespace Moodle3KL.Domain
{
    public class mdl_block_xp
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public long xp { get; set; }
        public long? lvl { get; set; }
    }
}