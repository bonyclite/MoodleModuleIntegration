namespace Moodle3KL.Domain
{
    public class mdl_scorm_seq_objective
    {
        public long id { get; set; }
        public long scoid { get; set; }
        public short primaryobj { get; set; }
        public string objectiveid { get; set; }
        public short satisfiedbymeasure { get; set; }
        public double minnormalizedmeasure { get; set; }
    }
}