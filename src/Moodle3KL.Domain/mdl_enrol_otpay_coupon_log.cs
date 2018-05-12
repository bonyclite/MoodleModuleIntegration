namespace Moodle3KL.Domain
{
    public class mdl_enrol_otpay_coupon_log
    {
        public long id { get; set; }
        public long couponid { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public long date { get; set; }
    }
}