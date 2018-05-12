namespace Moodle3KL.Domain
{
    public class mdl_license
    {
        public long id { get; set; }
        public string shortname { get; set; }
        public string fullname { get; set; }
        public string source { get; set; }
        public short enabled { get; set; }
        public long version { get; set; }
    }
}