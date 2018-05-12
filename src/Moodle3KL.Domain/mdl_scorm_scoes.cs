namespace Moodle3KL.Domain
{
    public class mdl_scorm_scoes
    {
        public long id { get; set; }
        public long scorm { get; set; }
        public string manifest { get; set; }
        public string organization { get; set; }
        public string parent { get; set; }
        public string identifier { get; set; }
        public string launch { get; set; }
        public string scormtype { get; set; }
        public string title { get; set; }
        public long sortorder { get; set; }
    }
}