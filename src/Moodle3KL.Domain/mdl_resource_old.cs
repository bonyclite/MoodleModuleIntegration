namespace Moodle3KL.Domain
{
    public class mdl_resource_old
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string reference { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string alltext { get; set; }
        public string popup { get; set; }
        public string options { get; set; }
        public long timemodified { get; set; }
        public long oldid { get; set; }
        public long? cmid { get; set; }
        public string newmodule { get; set; }
        public long? newid { get; set; }
        public long migrated { get; set; }
    }
}