namespace Moodle3KL.Domain
{
    public class mdl_block_dof_s_schevents : mdl_entity_base
    {
        public long? templateid { get; set; }
        public long? dayid { get; set; }
        public long? planid { get; set; }
        public string type { get; set; }
        public long joinid { get; set; }
        public long? cstreamid { get; set; }
        public long? teacherid { get; set; }
        public long? date { get; set; }
        public long? duration { get; set; }
        public string place { get; set; }
        public long? replaceid { get; set; }
        public string status { get; set; }
        public string form { get; set; }
        public long? appointmentid { get; set; }
        public long? ahours { get; set; }
        public double salfactor { get; set; }
        public string salfactorparts { get; set; }
        public double? rhours { get; set; }
    }
}