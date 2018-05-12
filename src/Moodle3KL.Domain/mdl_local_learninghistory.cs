namespace Moodle3KL.Domain
{
    public class mdl_local_learninghistory
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public decimal? finalgrade { get; set; }
        public decimal? completion { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public string status { get; set; }
        public long? lastupdate { get; set; }
        public string enroltype { get; set; }
        public long? previd { get; set; }
        public short? graderestored { get; set; }
    }
}