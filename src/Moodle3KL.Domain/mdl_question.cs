namespace Moodle3KL.Domain
{
    public class mdl_question
    {
        public long id { get; set; }
        public long category { get; set; }
        public long parent { get; set; }
        public string name { get; set; }
        public string questiontext { get; set; }
        public short questiontextformat { get; set; }
        public string generalfeedback { get; set; }
        public short generalfeedbackformat { get; set; }
        public decimal defaultmark { get; set; }
        public decimal penalty { get; set; }
        public string qtype { get; set; }
        public long length { get; set; }
        public string stamp { get; set; }
        public string version { get; set; }
        public short hidden { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long? createdby { get; set; }
        public long? modifiedby { get; set; }
    }
}