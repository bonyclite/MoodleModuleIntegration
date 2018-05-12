namespace Moodle3KL.Domain
{
    public class mdl_subcourse
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long timefetched { get; set; }
        public long refcourse { get; set; }
        public short instantredirect { get; set; }
    }
}