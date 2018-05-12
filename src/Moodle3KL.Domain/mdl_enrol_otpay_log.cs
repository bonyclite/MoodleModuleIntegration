namespace Moodle3KL.Domain
{
    public class mdl_enrol_otpay_log : mdl_entity_base
    {
        public long? timestamp { get; set; }
        public string textlog { get; set; }
        public string data { get; set; }
    }
}