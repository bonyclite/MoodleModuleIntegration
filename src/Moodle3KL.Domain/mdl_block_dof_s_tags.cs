namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_tags : mdl_entity_base
    {
        public string @class { get; set; }
        public long parentid { get; set; }
        public long ownerid { get; set; }
        public long departmentid { get; set; }
        public string options { get; set; }
        public long cron { get; set; }
        public long? crondone { get; set; }
        public string cronstatus { get; set; }
        public long cronrepeate { get; set; }
        public string about { get; set; }
        public string code { get; set; }
        public string alias { get; set; }
        public string status { get; set; }
    }
}