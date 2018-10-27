namespace Moodle3KL.Domain
{
    public class mdl_glossary_entries : mdl_entity_base
    {
        public long glossaryid { get; set; }
        public long userid { get; set; }
        public string concept { get; set; }
        public string definition { get; set; }
        public short definitionformat { get; set; }
        public short definitiontrust { get; set; }
        public string attachment { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short teacherentry { get; set; }
        public long sourceglossaryid { get; set; }
        public short usedynalink { get; set; }
        public short casesensitive { get; set; }
        public short fullmatch { get; set; }
        public short approved { get; set; }
    }
}