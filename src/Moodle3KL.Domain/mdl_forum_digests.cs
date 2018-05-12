namespace Moodle3KL.Domain
{
    public class mdl_forum_digests
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long forum { get; set; }
        public short maildigest { get; set; }
    }
}