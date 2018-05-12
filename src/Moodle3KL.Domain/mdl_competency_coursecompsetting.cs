namespace Moodle3KL.Domain
{
    public class mdl_competency_coursecompsetting
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public short? pushratingstouserplans { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? usermodified { get; set; }
    }
}