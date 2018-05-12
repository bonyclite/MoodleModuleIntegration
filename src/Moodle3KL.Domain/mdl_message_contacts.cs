namespace Moodle3KL.Domain
{
    public class mdl_message_contacts
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long contactid { get; set; }
        public short blocked { get; set; }
    }
}