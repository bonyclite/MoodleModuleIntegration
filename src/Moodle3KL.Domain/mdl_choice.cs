namespace Moodle3KL.Domain
{
    public class mdl_choice : mdl_entity_base
    {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short publish { get; set; }
        public short showresults { get; set; }
        public short display { get; set; }
        public short allowupdate { get; set; }
        public short allowmultiple { get; set; }
        public short showunanswered { get; set; }
        public short includeinactive { get; set; }
        public short limitanswers { get; set; }
        public long timeopen { get; set; }
        public long timeclose { get; set; }
        public short showpreview { get; set; }
        public long timemodified { get; set; }
        public short completionsubmit { get; set; }
    }
}