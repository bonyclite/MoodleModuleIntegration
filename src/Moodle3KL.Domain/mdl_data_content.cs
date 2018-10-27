namespace Moodle3KL.Domain
{
    public class mdl_data_content : mdl_entity_base
    {
        public long fieldid { get; set; }
        public long recordid { get; set; }
        public string content { get; set; }
        public string content1 { get; set; }
        public string content2 { get; set; }
        public string content3 { get; set; }
        public string content4 { get; set; }
    }
}