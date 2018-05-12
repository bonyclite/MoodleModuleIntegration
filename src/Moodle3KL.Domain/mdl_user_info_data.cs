namespace Moodle3KL.Domain
{
    public class mdl_user_info_data : mdl_entity_base
    {
        public long userid { get; set; }
        public long fieldid { get; set; }
        public string data { get; set; }
        public short dataformat { get; set; }
    }
}