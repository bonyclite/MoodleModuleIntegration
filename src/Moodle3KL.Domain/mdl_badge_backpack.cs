namespace Moodle3KL.Domain
{
    public class mdl_badge_backpack : mdl_entity_base
    {
        public long userid { get; set; }
        public string email { get; set; }
        public string backpackurl { get; set; }
        public long backpackuid { get; set; }
        public short autosync { get; set; }
        public string password { get; set; }
    }
}