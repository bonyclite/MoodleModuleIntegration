namespace Moodle3KL.Domain
{
    public class mdl_user_password_resets : mdl_entity_base
    {
        public long userid { get; set; }
        public long timerequested { get; set; }
        public long timererequested { get; set; }
        public string token { get; set; }
    }
}