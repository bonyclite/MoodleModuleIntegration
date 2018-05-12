namespace Moodle3KL.Domain
{
    public class mdl_events_queue_handlers
    {
        public long id { get; set; }
        public long queuedeventid { get; set; }
        public long handlerid { get; set; }
        public long? status { get; set; }
        public string errormessage { get; set; }
        public long timemodified { get; set; }
    }
}