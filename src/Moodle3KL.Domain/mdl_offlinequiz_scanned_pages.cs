namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_scanned_pages : mdl_entity_base {
        public long offlinequizid { get; set; }
        public long? resultid { get; set; }
        public string filename { get; set; }
        public string warningfilename { get; set; }
        public short? groupnumber { get; set; }
        public string userkey { get; set; }
        public short? pagenumber { get; set; }
        public long time { get; set; }
        public string status { get; set; }
        public string error { get; set; }
        public string info { get; set; }
    }
}