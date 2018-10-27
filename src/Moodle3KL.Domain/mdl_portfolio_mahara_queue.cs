namespace Moodle3KL.Domain
{
    public class mdl_portfolio_mahara_queue : mdl_entity_base
    {
        public long transferid { get; set; }
        public string token { get; set; }
    }
}