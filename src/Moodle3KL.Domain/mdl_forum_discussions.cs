namespace Moodle3KL.Domain
{
    public class mdl_forum_discussions
    {
        public long id { get; set; }
        public long course { get; set; }
        public long forum { get; set; }
        public string name { get; set; }
        public long firstpost { get; set; }
        public long userid { get; set; }
        public long groupid { get; set; }
        public short assessed { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
        public long timestart { get; set; }
        public long timeend { get; set; }
        public short pinned { get; set; }
    }
}