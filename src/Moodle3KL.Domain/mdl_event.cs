namespace Moodle3KL.Domain
{
    public class mdl_event : mdl_entity_base
    {
        public string name { get; set; }
        public string description { get; set; }
        public short format { get; set; }
        public long courseid { get; set; }
        public long groupid { get; set; }
        public long userid { get; set; }
        public long repeatid { get; set; }
        public string modulename { get; set; }
        public long instance { get; set; }
        public string eventtype { get; set; }
        public long timestart { get; set; }
        public long timeduration { get; set; }
        public short visible { get; set; }
        public string uuid { get; set; }
        public long sequence { get; set; }
        public long timemodified { get; set; }
        public long? subscriptionid { get; set; }
    }
}