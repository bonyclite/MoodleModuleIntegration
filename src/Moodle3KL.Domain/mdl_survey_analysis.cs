namespace Moodle3KL.Domain
{
    public class mdl_survey_analysis
    {
        public long id { get; set; }
        public long survey { get; set; }
        public long userid { get; set; }
        public string notes { get; set; }
    }
}