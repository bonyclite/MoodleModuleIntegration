namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_participants : mdl_entity_base {
        public long listid { get; set; }
        public long userid { get; set; }
        public short @checked { get; set; }
    }
}