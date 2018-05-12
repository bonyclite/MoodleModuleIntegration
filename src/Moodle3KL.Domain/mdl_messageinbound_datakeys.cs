namespace Moodle3KL.Domain
{
    public class mdl_messageinbound_datakeys
    {
        public long id { get; set; }
        public long handler { get; set; }
        public long datavalue { get; set; }
        public string datakey { get; set; }
        public long timecreated { get; set; }
        public long? expires { get; set; }
    }
}