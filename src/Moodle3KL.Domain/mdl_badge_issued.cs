namespace Moodle3KL.Domain
{
    public class mdl_badge_issued
    {
        public long id { get; set; }
        public long badgeid { get; set; }
        public long userid { get; set; }
        public string uniquehash { get; set; }
        public long dateissued { get; set; }
        public long? dateexpire { get; set; }
        public short visible { get; set; }
        public long? issuernotified { get; set; }
    }
}