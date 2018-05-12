namespace Moodle3KL.Domain
{
    public class mdl_tag_coll
    {
        public long id { get; set; }
        public string name { get; set; }
        public short isdefault { get; set; }
        public string component { get; set; }
        public int sortorder { get; set; }
        public short searchable { get; set; }
        public string customurl { get; set; }
    }
}