namespace Moodle3KL.Domain
{
    public class mdl_events_handlers
    {
        public long id { get; set; }
        public string eventname { get; set; }
        public string component { get; set; }
        public string handlerfile { get; set; }
        public string handlerfunction { get; set; }
        public string schedule { get; set; }
        public long status { get; set; }
        public short @internal { get; set; }
    }
}