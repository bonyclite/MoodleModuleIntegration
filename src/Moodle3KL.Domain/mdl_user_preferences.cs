namespace Moodle3KL.Domain
{
    public class mdl_user_preferences
    {
        public long id { get; set; }
        public long userid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}