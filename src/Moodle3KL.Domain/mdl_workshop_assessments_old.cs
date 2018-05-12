namespace Moodle3KL.Domain
{
    public class mdl_workshop_assessments_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public long submissionid { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timegraded { get; set; }
        public long timeagreed { get; set; }
        public double grade { get; set; }
        public short gradinggrade { get; set; }
        public short teachergraded { get; set; }
        public short mailed { get; set; }
        public short resubmission { get; set; }
        public short donotuse { get; set; }
        public string generalcomment { get; set; }
        public string teachercomment { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}