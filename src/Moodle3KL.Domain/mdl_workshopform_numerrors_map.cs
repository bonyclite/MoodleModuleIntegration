namespace Moodle3KL.Domain
{
    public class mdl_workshopform_numerrors_map : mdl_entity_base
    {
        public long workshopid { get; set; }
        public long nonegative { get; set; }
        public decimal grade { get; set; }
    }
}