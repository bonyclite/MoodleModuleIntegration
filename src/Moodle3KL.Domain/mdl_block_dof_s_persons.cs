namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_persons : mdl_entity_base
    {
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string sortname { get; set; }
        public string preferredname { get; set; }
        public long? dateofbirth { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phonehome { get; set; }
        public string phonework { get; set; }
        public string phonecell { get; set; }
        public short? passtypeid { get; set; }
        public string passportserial { get; set; }
        public string passportnum { get; set; }
        public long? passportdate { get; set; }
        public string passportem { get; set; }
        public string citizenship { get; set; }
        public long? passportaddrid { get; set; }
        public long? mdluser { get; set; }
        public string sync2moodle { get; set; }
        public long? addressid { get; set; }
        public string status { get; set; }
        public long? adddate { get; set; }
        public long? birthaddressid { get; set; }
        public long? departmentid { get; set; }
        public string about { get; set; }
        public string skype { get; set; }
        public string phoneadd1 { get; set; }
        public string phoneadd2 { get; set; }
        public string phoneadd3 { get; set; }
        public string emailadd1 { get; set; }
        public string emailadd2 { get; set; }
        public string emailadd3 { get; set; }
    }
}