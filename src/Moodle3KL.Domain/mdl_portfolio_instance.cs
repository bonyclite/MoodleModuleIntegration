namespace Moodle3KL.Domain
{
    public class mdl_portfolio_instance : mdl_entity_base
    {
        public string plugin { get; set; }
        public string name { get; set; }
        public short visible { get; set; }
    }
}