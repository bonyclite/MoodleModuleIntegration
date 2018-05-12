namespace Moodle3KL.Domain
{
    public class mdl_mnet_service : mdl_entity_base
    {
        public string name { get; set; }
        public string description { get; set; }
        public string apiversion { get; set; }
        public short offer { get; set; }
    }
}