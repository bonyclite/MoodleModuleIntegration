namespace Moodle3KL.Domain
{
    public class mdl_checklist_comment
    {
        public long id { get; set; }
        public long itemid { get; set; }
        public long userid { get; set; }
        public long? commentby { get; set; }
        public string text { get; set; }
    }
}