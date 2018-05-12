namespace Moodle3KL.Domain
{
    public class mdl_block_instances : mdl_entity_base {
        public string blockname { get; set; }
        public long parentcontextid { get; set; }
        public short showinsubcontexts { get; set; }
        public string pagetypepattern { get; set; }
        public string subpagepattern { get; set; }
        public string defaultregion { get; set; }
        public long defaultweight { get; set; }
        public string configdata { get; set; }
    }
}