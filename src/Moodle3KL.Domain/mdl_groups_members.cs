namespace Moodle3KL.Domain
{
    public class mdl_groups_members
    {
        public long id { get; set; }
        public long groupid { get; set; }
        public long userid { get; set; }
        public long timeadded { get; set; }
        public string component { get; set; }
        public long itemid { get; set; }
    }
}