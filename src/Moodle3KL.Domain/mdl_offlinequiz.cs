namespace Moodle3KL.Domain
{
    public class mdl_offlinequiz : mdl_entity_base {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string pdfintro { get; set; }
        public long timeopen { get; set; }
        public long timeclose { get; set; }
        public long time { get; set; }
        public decimal grade { get; set; }
        public long numgroups { get; set; }
        public short decimalpoints { get; set; }
        public long review { get; set; }
        public long questionsperpage { get; set; }
        public short docscreated { get; set; }
        public short shufflequestions { get; set; }
        public short shuffleanswers { get; set; }
        public short printstudycodefield { get; set; }
        public long papergray { get; set; }
        public short fontsize { get; set; }
        public long timecreated { get; set; }
        public short showquestioninfo { get; set; }
        public long timemodified { get; set; }
        public short fileformat { get; set; }
        public short showgrades { get; set; }
        public short showtutorial { get; set; }
    }
}