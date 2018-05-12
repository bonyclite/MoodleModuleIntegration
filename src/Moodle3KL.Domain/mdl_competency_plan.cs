namespace Moodle3KL.Domain
{
    public class mdl_competency_plan : mdl_entity_base
    {
        public string name { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long userid { get; set; }
        public long? templateid { get; set; }
        public long? origtemplateid { get; set; }
        public short status { get; set; }
        public long? duedate { get; set; }
        public long? reviewerid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usermodified { get; set; }
    }
}