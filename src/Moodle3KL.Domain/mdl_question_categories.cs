namespace Moodle3KL.Domain
{
    public class mdl_question_categories
    {
        public long id { get; set; }
        public string name { get; set; }
        public long contextid { get; set; }
        public string info { get; set; }
        public short infoformat { get; set; }
        public string stamp { get; set; }
        public long parent { get; set; }
        public long sortorder { get; set; }
    }
}