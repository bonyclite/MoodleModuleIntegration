namespace Moodle3KL.Domain
{
    public class mdl_checklist_check : mdl_entity_base
    {
        public long item { get; set; }
        public long userid { get; set; }
        public long usertimestamp { get; set; }
        public short teachermark { get; set; }
        public long teachertimestamp { get; set; }
        public long? teacherid { get; set; }
    }
}