namespace Moodle3KL.Domain
{
    public class mdl_wiki
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string firstpagetitle { get; set; }
        public string wikimode { get; set; }
        public string defaultformat { get; set; }
        public short forceformat { get; set; }
        public long editbegin { get; set; }
        public long? editend { get; set; }
    }
}