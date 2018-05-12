namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_cpassed : mdl_entity_base
    {
        public long? cstreamid { get; set; }
        public long? programmsbcid { get; set; }
        public long? programmitemid { get; set; }
        public long? studentid { get; set; }
        public long? agroupid { get; set; }
        public string grade { get; set; }
        public string gradelevel { get; set; }
        public int? credit { get; set; }
        public string notice { get; set; }
        public long? repeatid { get; set; }
        public short? typesync { get; set; }
        public long? mdlinstance { get; set; }
        public long? teacherid { get; set; }
        public long? ageid { get; set; }
        public long? orderid { get; set; }
        public string status { get; set; }
        public long? begindate { get; set; }
        public long? enddate { get; set; }
        public long? sbcorderid { get; set; }
        public long? learninghistoryid { get; set; }
    }
}