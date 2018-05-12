namespace Moodle3KL.Domain
{
    public class mdl_checklist_item
    {
        public long id { get; set; }
        public long checklist { get; set; }
        public long userid { get; set; }
        public string displaytext { get; set; }
        public long position { get; set; }
        public int indent { get; set; }
        public short itemoptional { get; set; }
        public long? duetime { get; set; }
        public long? eventid { get; set; }
        public string colour { get; set; }
        public long? moduleid { get; set; }
        public short hidden { get; set; }
        public long? grouping { get; set; }
    }
}