namespace Moodle3KL.Domain
{
    public class mdl_tag_area
    {
        public long id { get; set; }
        public string component { get; set; }
        public string itemtype { get; set; }
        public short enabled { get; set; }
        public long tagcollid { get; set; }
        public string callback { get; set; }
        public string callbackfile { get; set; }
        public short showstandard { get; set; }
    }
}