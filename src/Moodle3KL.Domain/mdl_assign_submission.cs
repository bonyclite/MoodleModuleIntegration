namespace Moodle3KL.Domain
{
    public class mdl_assign_submission : mdl_entity_base
    {
        public long assignment { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string status { get; set; }
        public long groupid { get; set; }
        public long attemptnumber { get; set; }
        public short latest { get; set; }
    }
}