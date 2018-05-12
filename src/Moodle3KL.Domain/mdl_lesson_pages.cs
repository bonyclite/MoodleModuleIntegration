namespace Moodle3KL.Domain
{
    public class mdl_lesson_pages
    {
        public long id { get; set; }
        public long lessonid { get; set; }
        public long prevpageid { get; set; }
        public long nextpageid { get; set; }
        public short qtype { get; set; }
        public short qoption { get; set; }
        public short layout { get; set; }
        public short display { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string title { get; set; }
        public string contents { get; set; }
        public short contentsformat { get; set; }
    }
}