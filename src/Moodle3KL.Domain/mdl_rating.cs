namespace Moodle3KL.Domain
{
    public class mdl_rating : mdl_entity_base
    {
        public long contextid { get; set; }
        public string component { get; set; }
        public string ratingarea { get; set; }
        public long itemid { get; set; }
        public long scaleid { get; set; }
        public long rating { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}