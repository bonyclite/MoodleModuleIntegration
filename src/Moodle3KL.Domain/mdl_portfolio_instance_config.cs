namespace Moodle3KL.Domain
{
    public class mdl_portfolio_instance_config : mdl_entity_base
    {
        public long instance { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}