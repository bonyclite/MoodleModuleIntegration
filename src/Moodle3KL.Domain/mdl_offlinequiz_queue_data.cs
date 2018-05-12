namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_queue_data : mdl_entity_base
    {
        public long queueid { get; set; }
        public string filename { get; set; }
        public string status { get; set; }
        public string error { get; set; }
    }
}