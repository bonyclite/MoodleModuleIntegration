namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_sync
    {
        public long id { get; set; }
        public string downptype { get; set; }
        public string downpcode { get; set; }
        public string downsubstorage { get; set; }
        public string downid { get; set; }
        public string upptype { get; set; }
        public string uppcode { get; set; }
        public string upsubstorage { get; set; }
        public string upid { get; set; }
        public string direct { get; set; }
        public long? lasttime { get; set; }
        public string lastoperation { get; set; }
        public string downhash { get; set; }
        public string uphash { get; set; }
    }
}