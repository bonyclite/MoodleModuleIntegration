namespace Moodle3KL.Domain
{
    public class mdl_mnet_session
    {
        public long id { get; set; }
        public long userid { get; set; }
        public string username { get; set; }
        public string token { get; set; }
        public long mnethostid { get; set; }
        public string useragent { get; set; }
        public long confirm_timeout { get; set; }
        public string session_id { get; set; }
        public long expires { get; set; }
    }
}