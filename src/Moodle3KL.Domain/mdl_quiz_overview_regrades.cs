namespace Moodle3KL.Domain
{
    public class mdl_quiz_overview_regrades
    {
        public long id { get; set; }
        public long questionusageid { get; set; }
        public long slot { get; set; }
        public decimal? newfraction { get; set; }
        public decimal? oldfraction { get; set; }
        public short regraded { get; set; }
        public long timemodified { get; set; }
    }
}