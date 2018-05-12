namespace Moodle3KL.Domain
{
    public class mdl_workshop_stockcomments_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public long elementno { get; set; }
        public string comments { get; set; }
        public string newplugin { get; set; }
        public long? newid { get; set; }
    }
}