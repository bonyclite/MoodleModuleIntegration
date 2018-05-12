namespace Moodle3KL.Domain
{
    public class mdl_grade_grades
    {
        public long id { get; set; }
        public long itemid { get; set; }
        public long userid { get; set; }
        public decimal? rawgrade { get; set; }
        public decimal rawgrademax { get; set; }
        public decimal rawgrademin { get; set; }
        public long? rawscaleid { get; set; }
        public long? usermodified { get; set; }
        public decimal? finalgrade { get; set; }
        public long hidden { get; set; }
        public long locked { get; set; }
        public long locktime { get; set; }
        public long exported { get; set; }
        public long overridden { get; set; }
        public long excluded { get; set; }
        public string feedback { get; set; }
        public long feedbackformat { get; set; }
        public string information { get; set; }
        public long informationformat { get; set; }
        public long? timecreated { get; set; }
        public long? timemodified { get; set; }
        public string aggregationstatus { get; set; }
        public decimal? aggregationweight { get; set; }
    }
}