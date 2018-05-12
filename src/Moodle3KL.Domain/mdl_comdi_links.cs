namespace Moodle3KL.Domain
{
    public class mdl_comdi_links
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long eventid { get; set; }
        public string link { get; set; }
        public long timecreated { get; set; }
    }
}