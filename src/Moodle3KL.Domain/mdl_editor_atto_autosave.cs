namespace Moodle3KL.Domain
{
    public class mdl_editor_atto_autosave : mdl_entity_base {
        public string elementid { get; set; }
        public long contextid { get; set; }
        public string pagehash { get; set; }
        public long userid { get; set; }
        public string drafttext { get; set; }
        public long? draftid { get; set; }
        public string pageinstance { get; set; }
        public long timemodified { get; set; }
    }
}