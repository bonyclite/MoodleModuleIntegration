namespace Moodle3KL.Domain
{
    public class mdl_tag_correlation
    {
        public long id { get; set; }
        public long tagid { get; set; }
        public string correlatedtags { get; set; }
    }
}