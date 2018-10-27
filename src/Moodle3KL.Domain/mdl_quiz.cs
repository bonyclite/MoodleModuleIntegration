namespace Moodle3KL.Domain
{
    public class mdl_quiz : mdl_entity_base
    {
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public long timeopen { get; set; }
        public long timeclose { get; set; }
        public long timelimit { get; set; }
        public string overduehandling { get; set; }
        public long graceperiod { get; set; }
        public string preferredbehaviour { get; set; }
        public short canredoquestions { get; set; }
        public int attempts { get; set; }
        public short attemptonlast { get; set; }
        public short grademethod { get; set; }
        public short decimalpoints { get; set; }
        public short questiondecimalpoints { get; set; }
        public int reviewattempt { get; set; }
        public int reviewcorrectness { get; set; }
        public int reviewmarks { get; set; }
        public int reviewspecificfeedback { get; set; }
        public int reviewgeneralfeedback { get; set; }
        public int reviewrightanswer { get; set; }
        public int reviewoverallfeedback { get; set; }
        public long questionsperpage { get; set; }
        public string navmethod { get; set; }
        public short shuffleanswers { get; set; }
        public decimal sumgrades { get; set; }
        public decimal grade { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string password { get; set; }
        public string subnet { get; set; }
        public string browsersecurity { get; set; }
        public long delay1 { get; set; }
        public long delay2 { get; set; }
        public short showuserpicture { get; set; }
        public short showblocks { get; set; }
        public short? completionattemptsexhausted { get; set; }
        public short? completionpass { get; set; }
    }
}