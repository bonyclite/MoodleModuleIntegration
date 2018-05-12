namespace Moodle3KL.Domain
{
    public class mdl_badge
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usercreated { get; set; }
        public long usermodified { get; set; }
        public string issuername { get; set; }
        public string issuerurl { get; set; }
        public string issuercontact { get; set; }
        public long? expiredate { get; set; }
        public long? expireperiod { get; set; }
        public short type { get; set; }
        public long? courseid { get; set; }
        public string message { get; set; }
        public string messagesubject { get; set; }
        public short attachment { get; set; }
        public short notification { get; set; }
        public short status { get; set; }
        public long? nextcron { get; set; }
    }
}