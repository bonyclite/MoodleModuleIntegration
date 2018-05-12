namespace Moodle3KL.Domain
{
    public class mdl_my_pages
    {
        public long id { get; set; }
        public long? userid { get; set; }
        public string name { get; set; }
        public short @private { get; set; }
        public int sortorder { get; set; }
    }
}