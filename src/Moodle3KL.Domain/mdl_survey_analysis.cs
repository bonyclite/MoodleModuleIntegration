namespace Moodle3KL.Domain
{
    public class mdl_survey_analysis : mdl_entity_base
    {
        public long survey { get; set; }
        public long userid { get; set; }
        public string notes { get; set; }
    }
}