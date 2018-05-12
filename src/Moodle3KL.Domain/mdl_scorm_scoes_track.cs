namespace Moodle3KL.Domain
{
    public class mdl_scorm_scoes_track : mdl_entity_base {
        public long userid { get; set; }
        public long scormid { get; set; }
        public long scoid { get; set; }
        public long attempt { get; set; }
        public string element { get; set; }
        public string value { get; set; }
        public long timemodified { get; set; }
    }
}