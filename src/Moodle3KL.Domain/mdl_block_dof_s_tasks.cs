namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_tasks
    {
        public long id { get; set; }
        public long parentid { get; set; }
        public long assignedpersonid { get; set; }
        public long purchaserpersonid { get; set; }
        public string title { get; set; }
        public string about { get; set; }
        public string solution { get; set; }
        public long date { get; set; }
        public long? actualdate { get; set; }
        public long? deadlinedate { get; set; }
        public string status { get; set; }
    }
}