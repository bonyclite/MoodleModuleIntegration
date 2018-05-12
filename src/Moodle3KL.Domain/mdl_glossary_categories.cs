namespace Moodle3KL.Domain
{
    public class mdl_glossary_categories : mdl_entity_base {
        public long glossaryid { get; set; }
        public string name { get; set; }
        public short usedynalink { get; set; }
    }
}