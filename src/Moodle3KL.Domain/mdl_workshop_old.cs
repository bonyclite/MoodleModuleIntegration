namespace Moodle3KL.Domain
{
    public class mdl_workshop_old : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public short wtype { get; set; }
        public short nelements { get; set; }
        public short nattachments { get; set; }
        public short phase { get; set; }
        public short format { get; set; }
        public short gradingstrategy { get; set; }
        public short resubmit { get; set; }
        public short agreeassessments { get; set; }
        public short hidegrades { get; set; }
        public short anonymous { get; set; }
        public short includeself { get; set; }
        public long maxbytes { get; set; }
        public long submissionstart { get; set; }
        public long assessmentstart { get; set; }
        public long submissionend { get; set; }
        public long assessmentend { get; set; }
        public long releasegrades { get; set; }
        public short grade { get; set; }
        public short gradinggrade { get; set; }
        public short ntassessments { get; set; }
        public short assessmentcomps { get; set; }
        public short nsassessments { get; set; }
        public short overallocation { get; set; }
        public long timemodified { get; set; }
        public short teacherweight { get; set; }
        public short showleaguetable { get; set; }
        public short usepassword { get; set; }
        public string password { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}