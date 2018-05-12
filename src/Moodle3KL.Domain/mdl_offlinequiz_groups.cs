namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz_groups : mdl_entity_base {
        public long offlinequizid { get; set; }
        public short number { get; set; }
        public decimal sumgrades { get; set; }
        public short numberofpages { get; set; }
        public long templateusageid { get; set; }
        public string questionfilename { get; set; }
        public string answerfilename { get; set; }
        public string correctionfilename { get; set; }
    }
}