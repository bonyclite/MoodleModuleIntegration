namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_scanned_p_pages : mdl_entity_base {
        public long offlinequizid { get; set; }
        public short? listnumber { get; set; }
        public string filename { get; set; }
        public long time { get; set; }
        public string status { get; set; }
        public string error { get; set; }
    }
}