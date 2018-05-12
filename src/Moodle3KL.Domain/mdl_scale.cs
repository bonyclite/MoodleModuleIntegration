namespace Moodle3KL.Domain
{
    public class mdl_scale
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public string name { get; set; }
        public string scale { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long timemodified { get; set; }
    }
}