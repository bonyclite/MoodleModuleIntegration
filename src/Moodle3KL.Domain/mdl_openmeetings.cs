namespace Moodle3KL.Domain
{
    public class mdl_openmeetings
    {
        public long id { get; set; }
        public long course { get; set; }
        public long teacher { get; set; }
        public string type { get; set; }
        public long is_moderated_room { get; set; }
        public long max_user { get; set; }
        public long language { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long room_id { get; set; }
        public long room_recording_id { get; set; }
        public long allow_recording { get; set; }
        public long whole_window { get; set; }
        public long chat_hidden { get; set; }
    }
}