namespace Moodle3KL.Domain
{
    public class mdl_events_queue
    {
        public long id { get; set; }
        public string eventdata { get; set; }
        public string stackdump { get; set; }
        public long? userid { get; set; }
        public long timecreated { get; set; }
    }
}