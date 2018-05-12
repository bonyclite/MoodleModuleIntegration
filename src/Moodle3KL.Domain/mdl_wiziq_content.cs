namespace Moodle3KL.Domain
{
    public class mdl_wiziq_content
    {
        public long id { get; set; }
        public long? course { get; set; }
        public long? wiziqid { get; set; }
        public long type { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public long? parentid { get; set; }
        public long? prevparentid { get; set; }
        public string path { get; set; }
        public long? userid { get; set; }
        public long uploadtime { get; set; }
        public long? contentid { get; set; }
        public long? old_content_id { get; set; }
        public short? cid_change_status { get; set; }
        public long? status { get; set; }
        public long wcid { get; set; }
    }
}