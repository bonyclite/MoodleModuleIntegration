namespace Moodle3KL.Domain
{
    public class mdl_files_reference : mdl_entity_base
    {
        public long repositoryid { get; set; }
        public long? lastsync { get; set; }
        public string reference { get; set; }
        public string referencehash { get; set; }
    }
}