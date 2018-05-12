namespace Moodle3KL.Domain
{
    public class mdl_simplecertificate_issues : mdl_entity_base {
        public long certificateid { get; set; }
        public long userid { get; set; }
        public string certificatename { get; set; }
        public string code { get; set; }
        public long timecreated { get; set; }
        public long? timedeleted { get; set; }
        public short haschange { get; set; }
        public string pathnamehash { get; set; }
    }
}