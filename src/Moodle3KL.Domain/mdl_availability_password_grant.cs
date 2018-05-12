namespace Moodle3KL.Domain
{
    public class mdl_availability_password_grant : mdl_entity_base {
        public long courseid { get; set; }
        public long cmid { get; set; }
        public long userid { get; set; }
        public string password { get; set; }
    }
}