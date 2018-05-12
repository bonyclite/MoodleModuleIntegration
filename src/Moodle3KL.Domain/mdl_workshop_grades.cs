namespace Moodle3KL.Domain
{
    public class mdl_workshop_grades
    {
        public long id { get; set; }
        public long assessmentid { get; set; }
        public string strategy { get; set; }
        public long dimensionid { get; set; }
        public decimal grade { get; set; }
        public string peercomment { get; set; }
        public short? peercommentformat { get; set; }
    }
}