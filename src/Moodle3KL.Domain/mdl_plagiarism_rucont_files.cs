namespace Moodle3KL.Domain
{
    public class mdl_plagiarism_rucont_files : mdl_entity_base {
        public long cm { get; set; }
        public long userid { get; set; }
        public string identifier { get; set; }
        public long? externalid { get; set; }
        public string externalstatus { get; set; }
        public string statuscode { get; set; }
        public int? similarityscore { get; set; }
        public int attempt { get; set; }
        public string filename { get; set; }
        public string contenthash { get; set; }
        public long? lastmodified { get; set; }
        public string submissiontype { get; set; }
        public long? parentid { get; set; }
        public long? errorcode { get; set; }
        public string errormsg { get; set; }
        public string reporturl { get; set; }
    }
}