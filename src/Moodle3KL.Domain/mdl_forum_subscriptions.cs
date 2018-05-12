namespace Moodle3KL.Domain
{
    public class mdl_forum_subscriptions : mdl_entity_base
    {
        public long userid { get; set; }
        public long forum { get; set; }
    }
}