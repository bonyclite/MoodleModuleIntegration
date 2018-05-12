namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_organizations : mdl_entity_base
    {
        public string fullname { get; set; }
        public string shortname { get; set; }
        public long? inn { get; set; }
        public int? kpp { get; set; }
        public long? ogrn { get; set; }
        public string bankrequisites { get; set; }
        public long? legaladdressid { get; set; }
        public long? currentaddressid { get; set; }
        public long? mailingaddressid { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string additionalrequisites { get; set; }
        public string head { get; set; }
        public string posthead { get; set; }
        public string actionhead { get; set; }
    }
}