namespace Moodle3KL.Domain
{
    public class mdl_scorm_seq_ruleconds
    {
        public long id { get; set; }
        public long scoid { get; set; }
        public string conditioncombination { get; set; }
        public short ruletype { get; set; }
        public string action { get; set; }
    }
}