namespace Moodle3KL.Domain
{
    public class mdl_checklist_comment : mdl_entity_base
    {
        public long itemid { get; set; }
        public long userid { get; set; }
        public long? commentby { get; set; }
        public string text { get; set; }
    }
}