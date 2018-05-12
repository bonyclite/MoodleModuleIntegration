namespace Moodle3KL.Domain
{
    public class mdl_events_handlers : mdl_entity_base {
        public string eventname { get; set; }
        public string component { get; set; }
        public string handlerfile { get; set; }
        public string handlerfunction { get; set; }
        public string schedule { get; set; }
        public long status { get; set; }
        public short @internal { get; set; }
    }
}