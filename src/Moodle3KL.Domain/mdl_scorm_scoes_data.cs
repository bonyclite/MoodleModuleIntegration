namespace Moodle3KL.Domain
{
    public class mdl_scorm_scoes_data : mdl_entity_base
    {
        public long scoid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}