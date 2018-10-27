namespace Moodle3KL.Domain
{
    public class mdl_assign_user_mapping : mdl_entity_base
    {
        public long assignment { get; set; }
        public long userid { get; set; }
    }
}