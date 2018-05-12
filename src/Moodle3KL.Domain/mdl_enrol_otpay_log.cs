namespace Moodle3KL.Domain
{
    public class mdl_enrol_otpay_log
    {
        public long id { get; set; }
        public long? timestamp { get; set; }
        public string textlog { get; set; }
        public string data { get; set; }
    }
}