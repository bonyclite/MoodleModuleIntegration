namespace Moodle3KL.Domain
{
    public class mdl_enrol_otpay_coupons : mdl_entity_base {
        public long catid { get; set; }
        public string code { get; set; }
        public long? courseid { get; set; }
        public string type { get; set; }
        public string discounttype { get; set; }
        public double value { get; set; }
        public long createtime { get; set; }
        public long lifetime { get; set; }
        public string status { get; set; }
    }
}