namespace Moodle3KL.Domain
{
    public class mdl_workshopform_accumulative : mdl_entity_base {
        public long workshopid { get; set; }
        public long? sort { get; set; }
        public string description { get; set; }
        public short? descriptionformat { get; set; }
        public long grade { get; set; }
        public int? weight { get; set; }
    }
}