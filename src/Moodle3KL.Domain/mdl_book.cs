namespace Moodle3KL.Domain
{
    public class mdl_book : mdl_entity_base
    {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short numbering { get; set; }
        public short navstyle { get; set; }
        public short customtitles { get; set; }
        public long revision { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}