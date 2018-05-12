namespace Moodle3KL.Domain
{
    public class mdl_bigbluebuttonbn : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string meetingid { get; set; }
        public string moderatorpass { get; set; }
        public string viewerpass { get; set; }
        public short newwindow { get; set; }
        public short wait { get; set; }
        public short record { get; set; }
        public short tagging { get; set; }
        public string welcome { get; set; }
        public int voicebridge { get; set; }
        public long openingtime { get; set; }
        public long closingtime { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string presentation { get; set; }
        public string participants { get; set; }
        public short userlimit { get; set; }
    }
}