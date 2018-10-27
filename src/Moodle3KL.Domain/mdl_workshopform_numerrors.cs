namespace Moodle3KL.Domain
{
    public class mdl_workshopform_numerrors : mdl_entity_base
    {
        public long workshopid { get; set; }
        public long? sort { get; set; }
        public string description { get; set; }
        public short? descriptionformat { get; set; }
        public long? descriptiontrust { get; set; }
        public string grade0 { get; set; }
        public string grade1 { get; set; }
        public int? weight { get; set; }
    }
}