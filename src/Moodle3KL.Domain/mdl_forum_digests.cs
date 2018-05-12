namespace Moodle3KL.Domain
{
    public class mdl_forum_digests : mdl_entity_base {
        public long userid { get; set; }
        public long forum { get; set; }
        public short maildigest { get; set; }
    }
}