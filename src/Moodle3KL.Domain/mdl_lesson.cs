namespace Moodle3KL.Domain
{
    public class mdl_lesson
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short practice { get; set; }
        public short modattempts { get; set; }
        public short usepassword { get; set; }
        public string password { get; set; }
        public long dependency { get; set; }
        public string conditions { get; set; }
        public long grade { get; set; }
        public short custom { get; set; }
        public short ongoing { get; set; }
        public short usemaxgrade { get; set; }
        public short maxanswers { get; set; }
        public short maxattempts { get; set; }
        public short review { get; set; }
        public short nextpagedefault { get; set; }
        public short feedback { get; set; }
        public short minquestions { get; set; }
        public short maxpages { get; set; }
        public long timelimit { get; set; }
        public short retake { get; set; }
        public long activitylink { get; set; }
        public string mediafile { get; set; }
        public long mediaheight { get; set; }
        public long mediawidth { get; set; }
        public short mediaclose { get; set; }
        public short slideshow { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public string bgcolor { get; set; }
        public short displayleft { get; set; }
        public short displayleftif { get; set; }
        public short progressbar { get; set; }
        public long available { get; set; }
        public long deadline { get; set; }
        public long timemodified { get; set; }
        public short? completionendreached { get; set; }
        public long? completiontimespent { get; set; }
    }
}