namespace Moodle3KL.Domain
{
    public class mdl_groups_members : mdl_entity_base {
        public long groupid { get; set; }
        public long userid { get; set; }
        public long timeadded { get; set; }
        public string component { get; set; }
        public long itemid { get; set; }
    }
}