namespace Moodle3KL.Domain
{
    public class mdl_event_subscriptions
    {
        public long id { get; set; }
        public string url { get; set; }
        public long courseid { get; set; }
        public long groupid { get; set; }
        public long userid { get; set; }
        public string eventtype { get; set; }
        public long pollinterval { get; set; }
        public long? lastupdated { get; set; }
        public string name { get; set; }
    }
}