namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_participants
    {
        public long id { get; set; }
        public long listid { get; set; }
        public long userid { get; set; }
        public short @checked { get; set; }
    }
}