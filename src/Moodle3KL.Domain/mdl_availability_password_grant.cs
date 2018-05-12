namespace Moodle3KL.Domain
{
    public class mdl_availability_password_grant
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long cmid { get; set; }
        public long userid { get; set; }
        public string password { get; set; }
    }
}