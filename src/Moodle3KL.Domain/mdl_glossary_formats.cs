namespace Moodle3KL.Domain
{
    public class mdl_glossary_formats : mdl_entity_base
    {
        public string name { get; set; }
        public string popupformatname { get; set; }
        public short visible { get; set; }
        public short showgroup { get; set; }
        public string showtabs { get; set; }
        public string defaultmode { get; set; }
        public string defaulthook { get; set; }
        public string sortkey { get; set; }
        public string sortorder { get; set; }
    }
}