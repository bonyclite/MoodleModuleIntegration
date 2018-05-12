namespace Moodle3KL.Domain
{
    public class mdl_user_password_history
    {
        public long id { get; set; }
        public long userid { get; set; }
        public string hash { get; set; }
        public long timecreated { get; set; }
    }
}