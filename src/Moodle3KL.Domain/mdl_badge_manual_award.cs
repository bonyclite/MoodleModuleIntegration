namespace Moodle3KL.Domain
{
    public class mdl_badge_manual_award
    {
        public long id { get; set; }
        public long badgeid { get; set; }
        public long recipientid { get; set; }
        public long issuerid { get; set; }
        public long issuerrole { get; set; }
        public long datemet { get; set; }
    }
}