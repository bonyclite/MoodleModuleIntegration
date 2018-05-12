namespace Moodle3KL.Domain
{
    public class mdl_label
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short? introformat { get; set; }
        public long timemodified { get; set; }
    }
}