namespace Moodle3KL.Domain
{
    public class mdl_assignsubmission_onlinetext
    {
        public long id { get; set; }
        public long assignment { get; set; }
        public long submission { get; set; }
        public string onlinetext { get; set; }
        public short onlineformat { get; set; }
    }
}