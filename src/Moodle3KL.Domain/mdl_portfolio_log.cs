namespace Moodle3KL.Domain
{
    public class mdl_portfolio_log : mdl_entity_base {
        public long userid { get; set; }
        public long time { get; set; }
        public long portfolio { get; set; }
        public string caller_class { get; set; }
        public string caller_file { get; set; }
        public string caller_component { get; set; }
        public string caller_sha1 { get; set; }
        public long tempdataid { get; set; }
        public string returnurl { get; set; }
        public string continueurl { get; set; }
    }
}