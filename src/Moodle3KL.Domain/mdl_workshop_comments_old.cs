namespace Moodle3KL.Domain
{
    public class mdl_workshop_comments_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public long assessmentid { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public short mailed { get; set; }
        public string comments { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}