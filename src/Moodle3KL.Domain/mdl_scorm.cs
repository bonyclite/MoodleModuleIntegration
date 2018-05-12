namespace Moodle3KL.Domain
{
    public class mdl_scorm
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string scormtype { get; set; }
        public string reference { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string version { get; set; }
        public double maxgrade { get; set; }
        public short grademethod { get; set; }
        public long whatgrade { get; set; }
        public long maxattempt { get; set; }
        public short forcecompleted { get; set; }
        public short forcenewattempt { get; set; }
        public short lastattemptlock { get; set; }
        public short masteryoverride { get; set; }
        public short displayattemptstatus { get; set; }
        public short displaycoursestructure { get; set; }
        public short updatefreq { get; set; }
        public string sha1hash { get; set; }
        public string md5hash { get; set; }
        public long revision { get; set; }
        public long launch { get; set; }
        public short skipview { get; set; }
        public short hidebrowse { get; set; }
        public short hidetoc { get; set; }
        public short nav { get; set; }
        public long? navpositionleft { get; set; }
        public long? navpositiontop { get; set; }
        public short auto { get; set; }
        public short popup { get; set; }
        public string options { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public long timeopen { get; set; }
        public long timeclose { get; set; }
        public long timemodified { get; set; }
        public short? completionstatusrequired { get; set; }
        public short? completionscorerequired { get; set; }
        public short displayactivityname { get; set; }
        public short autocommit { get; set; }
    }
}