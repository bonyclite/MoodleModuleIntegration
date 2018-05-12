namespace Moodle3KL.Domain
{
    public class mdl_book_chapters
    {
        public long id { get; set; }
        public long bookid { get; set; }
        public long pagenum { get; set; }
        public long subchapter { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public short contentformat { get; set; }
        public short hidden { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string importsrc { get; set; }
    }
}