namespace Moodle3KL.Domain
{
    public class mdl_assignment : mdl_entity_base
    {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string assignmenttype { get; set; }
        public short resubmit { get; set; }
        public short preventlate { get; set; }
        public short emailteachers { get; set; }
        public long? var1 { get; set; }
        public long? var2 { get; set; }
        public long? var3 { get; set; }
        public long? var4 { get; set; }
        public long? var5 { get; set; }
        public long maxbytes { get; set; }
        public long timedue { get; set; }
        public long timeavailable { get; set; }
        public long grade { get; set; }
        public long timemodified { get; set; }
    }
}