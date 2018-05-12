namespace Moodle3KL.Domain
{
    public class mdl_badge_criteria
    {
        public long id { get; set; }
        public long badgeid { get; set; }
        public long? criteriatype { get; set; }
        public short method { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
    }
}