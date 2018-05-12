namespace Moodle3KL.Domain
{
    public class mdl_glossary_categories
    {
        public long id { get; set; }
        public long glossaryid { get; set; }
        public string name { get; set; }
        public short usedynalink { get; set; }
    }
}