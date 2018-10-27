using System.ComponentModel.DataAnnotations.Schema;

namespace Moodle3KL.Domain
{
    public class mdl_comdi : mdl_entity_base
    {
        public long course { get; set; }
        public long teacher { get; set; }
        public long type { get; set; }
        public long is_moderated_room { get; set; }
        public long max_user { get; set; }
        public long language { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string event_id { get; set; }
        public string start { get; set; }
        public short? opt_continuation { get; set; }

        [Column("end")]
        public long aend { get; set; }
    }
}